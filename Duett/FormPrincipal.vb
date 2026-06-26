Imports System.Data
Imports System.Net.Http
Imports System.Text
Imports System.Windows.Forms
Imports Newtonsoft.Json.Linq

Namespace Duett
    Partial Public Class FormPrincipal

        Private Async Sub btnSincronizar_Click(sender As Object, e As EventArgs) Handles btnSincronizar.Click
            If String.IsNullOrWhiteSpace(txtFone.Text) Then
                MessageBox.Show("Informe o telefone.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            btnSincronizar.Enabled = False
            lblStatus.Text = "Sincronizando..."

            Try
                Dim handler As New HttpClientHandler()
                handler.ServerCertificateCustomValidationCallback = Function(msg, cert, chain, errors) True

                Using client As New HttpClient(handler)
                    client.DefaultRequestHeaders.Add("fone", txtFone.Text.Trim())
                    client.DefaultRequestHeaders.Add("Cookie", "NSC_mc_psjpocs-rb3-qsfqspe_iuuq=ffffffff09e44c4045525d5f4f58455e445a4a423660")

                    Dim content As New StringContent("", Encoding.UTF8, "application/json")
                    Dim response = Await client.PostAsync(
                        "https://qa3orionbr-preprod.cevalogistics.com/WCFOrionMobilityMilkRun/Servicos/SincronizarService.svc/Sincronizar",
                        content)

                    Dim json = Await response.Content.ReadAsStringAsync()
                    Dim obj = JObject.Parse(json)
                    Dim result = obj("SincronizarResult")

                    If result Is Nothing Then
                        MessageBox.Show("Resposta sem SincronizarResult.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    PreencherViagem(result)
                    PreencherGridParadas(dgvFornecedores, result("Fornecedores"))
                    PreencherGridParadas(dgvDestinatarios, result("Destinatarios"))
                    PreencherGridPlantas(result("plantas"))

                    lblStatus.Text = "OK - Viagem: " & result.Value(Of String)("NumeroViagem")
                End Using
            Catch ex As Exception
                lblStatus.Text = "Erro"
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                btnSincronizar.Enabled = True
            End Try
        End Sub

        Private Sub PreencherViagem(result As JToken)
            txtNumeroViagem.Text = result.Value(Of String)("NumeroViagem")
            txtDataViagem.Text = result.Value(Of String)("DataViagem")
            txtRota.Text = result.Value(Of String)("Rota")?.Trim()
            txtTipoViagem.Text = result.Value(Of String)("TipoViagem")
            txtPlacaCavalo.Text = result.Value(Of String)("PlacaCavalo")
            txtPlacaCarreta1.Text = result.Value(Of String)("PlacaCarreta1")
            txtPlacaCarreta2.Text = result.Value(Of String)("PlacaCarreta2")
            txtPontoOperacional.Text = result.Value(Of String)("PontoOperacional")
            txtManifestar.Text = result.Value(Of String)("Manifestar")
            txtVazia.Text = If(result.Value(Of Boolean?)("Vazia")?.ToString(), "")
            txtExecutouOK.Text = If(result.Value(Of Boolean?)("ExecutouOK")?.ToString(), "")
            txtErro.Text = result.Value(Of String)("Erro")
        End Sub

        Private Sub PreencherGridParadas(dgv As DataGridView, items As JToken)
            If items Is Nothing Then Return
            Dim dt As New DataTable()
            dt.Columns.Add("Ordem")
            dt.Columns.Add("Descricao Parada")
            dt.Columns.Add("1")
            dt.Columns.Add("2")
            dt.Columns.Add("3")
            dt.Columns.Add("Razao Social")
            dt.Columns.Add("CNPJ")
            dt.Columns.Add("Endereco")
            dt.Columns.Add("Codigo")
            dt.Columns.Add("Cutoff")
            Dim descricao As String
            Dim partes As String()
            For Each item In items

                descricao = item.Value(Of String)("descricaoParada")
                partes = descricao.Split("-"c)
                ReDim Preserve partes(2)
                dt.Rows.Add(
                    item.Value(Of String)("ordemParada"),
                    descricao,'Descricao
                    partes(0),'1
                    partes(1),'2
                    partes(2),'3
                    item.Value(Of String)("razaoSocial"),
                    item.Value(Of String)("cnpj"),
                    item.Value(Of String)("endereco"),
                    item.Value(Of String)("codigoGeral"),
                    item.Value(Of String)("cutoff"))
            Next
            dgv.DataSource = dt
        End Sub

        Private Sub PreencherGridPlantas(items As JToken)
            If items Is Nothing Then Return
            Dim dt As New DataTable()
            dt.Columns.Add("Codigo")
            dt.Columns.Add("Descricao")
            dt.Columns.Add("CNPJ")
            dt.Columns.Add("Resp")
            For Each item In items
                dt.Rows.Add(
                    item.Value(Of String)("codigo"),
                    item.Value(Of String)("descricao"),
                    item.Value(Of String)("cnpj"),
                    item.Value(Of String)("resp"))
            Next
            dgvPlantas.DataSource = dt
        End Sub

    End Class
End Namespace
