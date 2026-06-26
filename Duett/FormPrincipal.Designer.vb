Namespace Duett
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormPrincipal
        Inherits System.Windows.Forms.Form

        Private components As System.ComponentModel.IContainer

        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            pnlTopo = New System.Windows.Forms.Panel()
            lblFone = New System.Windows.Forms.Label()
            txtFone = New System.Windows.Forms.TextBox()
            btnSincronizar = New System.Windows.Forms.Button()
            lblStatus = New System.Windows.Forms.Label()
            tabControl = New System.Windows.Forms.TabControl()
            tabViagem = New System.Windows.Forms.TabPage()
            pnlViagem = New System.Windows.Forms.Panel()
            lblNumeroViagem = New System.Windows.Forms.Label()
            txtNumeroViagem = New System.Windows.Forms.TextBox()
            lblDataViagem = New System.Windows.Forms.Label()
            txtDataViagem = New System.Windows.Forms.TextBox()
            lblRota = New System.Windows.Forms.Label()
            txtRota = New System.Windows.Forms.TextBox()
            lblTipoViagem = New System.Windows.Forms.Label()
            txtTipoViagem = New System.Windows.Forms.TextBox()
            lblPlacaCavalo = New System.Windows.Forms.Label()
            txtPlacaCavalo = New System.Windows.Forms.TextBox()
            lblPlacaCarreta1 = New System.Windows.Forms.Label()
            txtPlacaCarreta1 = New System.Windows.Forms.TextBox()
            lblPlacaCarreta2 = New System.Windows.Forms.Label()
            txtPlacaCarreta2 = New System.Windows.Forms.TextBox()
            lblPontoOperacional = New System.Windows.Forms.Label()
            txtPontoOperacional = New System.Windows.Forms.TextBox()
            lblManifestar = New System.Windows.Forms.Label()
            txtManifestar = New System.Windows.Forms.TextBox()
            lblVazia = New System.Windows.Forms.Label()
            txtVazia = New System.Windows.Forms.TextBox()
            lblExecutouOK = New System.Windows.Forms.Label()
            txtExecutouOK = New System.Windows.Forms.TextBox()
            lblErro = New System.Windows.Forms.Label()
            txtErro = New System.Windows.Forms.TextBox()
            tabFornecedores = New System.Windows.Forms.TabPage()
            dgvFornecedores = New System.Windows.Forms.DataGridView()
            tabDestinatarios = New System.Windows.Forms.TabPage()
            dgvDestinatarios = New System.Windows.Forms.DataGridView()
            tabPlantas = New System.Windows.Forms.TabPage()
            dgvPlantas = New System.Windows.Forms.DataGridView()
            pnlTopo.SuspendLayout()
            tabControl.SuspendLayout()
            tabViagem.SuspendLayout()
            pnlViagem.SuspendLayout()
            tabFornecedores.SuspendLayout()
            CType(dgvFornecedores, ComponentModel.ISupportInitialize).BeginInit()
            tabDestinatarios.SuspendLayout()
            CType(dgvDestinatarios, ComponentModel.ISupportInitialize).BeginInit()
            tabPlantas.SuspendLayout()
            CType(dgvPlantas, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' pnlTopo
            ' 
            pnlTopo.Controls.Add(lblFone)
            pnlTopo.Controls.Add(txtFone)
            pnlTopo.Controls.Add(btnSincronizar)
            pnlTopo.Controls.Add(lblStatus)
            pnlTopo.Dock = System.Windows.Forms.DockStyle.Top
            pnlTopo.Location = New System.Drawing.Point(0, 0)
            pnlTopo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            pnlTopo.Name = "pnlTopo"
            pnlTopo.Size = New System.Drawing.Size(800, 67)
            pnlTopo.TabIndex = 0
            ' 
            ' lblFone
            ' 
            lblFone.AutoSize = True
            lblFone.Location = New System.Drawing.Point(14, 24)
            lblFone.Name = "lblFone"
            lblFone.Size = New System.Drawing.Size(44, 20)
            lblFone.TabIndex = 0
            lblFone.Text = "Fone:"
            ' 
            ' txtFone
            ' 
            txtFone.Location = New System.Drawing.Point(63, 20)
            txtFone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtFone.Name = "txtFone"
            txtFone.Size = New System.Drawing.Size(205, 27)
            txtFone.TabIndex = 1
            txtFone.Text = "11996725978"
            ' 
            ' btnSincronizar
            ' 
            btnSincronizar.Location = New System.Drawing.Point(286, 17)
            btnSincronizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            btnSincronizar.Name = "btnSincronizar"
            btnSincronizar.Size = New System.Drawing.Size(126, 37)
            btnSincronizar.TabIndex = 2
            btnSincronizar.Text = "Sincronizar"
            btnSincronizar.UseVisualStyleBackColor = True
            ' 
            ' lblStatus
            ' 
            lblStatus.AutoSize = True
            lblStatus.Location = New System.Drawing.Point(429, 24)
            lblStatus.Name = "lblStatus"
            lblStatus.Size = New System.Drawing.Size(0, 20)
            lblStatus.TabIndex = 3
            ' 
            ' tabControl
            ' 
            tabControl.Controls.Add(tabViagem)
            tabControl.Controls.Add(tabFornecedores)
            tabControl.Controls.Add(tabDestinatarios)
            tabControl.Controls.Add(tabPlantas)
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill
            tabControl.Location = New System.Drawing.Point(0, 67)
            tabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            tabControl.Name = "tabControl"
            tabControl.SelectedIndex = 0
            tabControl.Size = New System.Drawing.Size(800, 626)
            tabControl.TabIndex = 1
            ' 
            ' tabViagem
            ' 
            tabViagem.Controls.Add(pnlViagem)
            tabViagem.Location = New System.Drawing.Point(4, 29)
            tabViagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            tabViagem.Name = "tabViagem"
            tabViagem.Size = New System.Drawing.Size(792, 593)
            tabViagem.TabIndex = 0
            tabViagem.Text = "Viagem"
            tabViagem.UseVisualStyleBackColor = True
            ' 
            ' pnlViagem
            ' 
            pnlViagem.AutoScroll = True
            pnlViagem.Controls.Add(lblNumeroViagem)
            pnlViagem.Controls.Add(txtNumeroViagem)
            pnlViagem.Controls.Add(lblDataViagem)
            pnlViagem.Controls.Add(txtDataViagem)
            pnlViagem.Controls.Add(lblRota)
            pnlViagem.Controls.Add(txtRota)
            pnlViagem.Controls.Add(lblTipoViagem)
            pnlViagem.Controls.Add(txtTipoViagem)
            pnlViagem.Controls.Add(lblPlacaCavalo)
            pnlViagem.Controls.Add(txtPlacaCavalo)
            pnlViagem.Controls.Add(lblPlacaCarreta1)
            pnlViagem.Controls.Add(txtPlacaCarreta1)
            pnlViagem.Controls.Add(lblPlacaCarreta2)
            pnlViagem.Controls.Add(txtPlacaCarreta2)
            pnlViagem.Controls.Add(lblPontoOperacional)
            pnlViagem.Controls.Add(txtPontoOperacional)
            pnlViagem.Controls.Add(lblManifestar)
            pnlViagem.Controls.Add(txtManifestar)
            pnlViagem.Controls.Add(lblVazia)
            pnlViagem.Controls.Add(txtVazia)
            pnlViagem.Controls.Add(lblExecutouOK)
            pnlViagem.Controls.Add(txtExecutouOK)
            pnlViagem.Controls.Add(lblErro)
            pnlViagem.Controls.Add(txtErro)
            pnlViagem.Dock = System.Windows.Forms.DockStyle.Fill
            pnlViagem.Location = New System.Drawing.Point(0, 0)
            pnlViagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            pnlViagem.Name = "pnlViagem"
            pnlViagem.Padding = New System.Windows.Forms.Padding(17, 20, 17, 20)
            pnlViagem.Size = New System.Drawing.Size(792, 593)
            pnlViagem.TabIndex = 0
            ' 
            ' lblNumeroViagem
            ' 
            lblNumeroViagem.AutoSize = True
            lblNumeroViagem.Location = New System.Drawing.Point(17, 24)
            lblNumeroViagem.Name = "lblNumeroViagem"
            lblNumeroViagem.Size = New System.Drawing.Size(121, 20)
            lblNumeroViagem.TabIndex = 0
            lblNumeroViagem.Text = "Numero Viagem:"
            ' 
            ' txtNumeroViagem
            ' 
            txtNumeroViagem.Location = New System.Drawing.Point(160, 20)
            txtNumeroViagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtNumeroViagem.Name = "txtNumeroViagem"
            txtNumeroViagem.ReadOnly = True
            txtNumeroViagem.Size = New System.Drawing.Size(457, 27)
            txtNumeroViagem.TabIndex = 1
            ' 
            ' lblDataViagem
            ' 
            lblDataViagem.AutoSize = True
            lblDataViagem.Location = New System.Drawing.Point(17, 67)
            lblDataViagem.Name = "lblDataViagem"
            lblDataViagem.Size = New System.Drawing.Size(99, 20)
            lblDataViagem.TabIndex = 2
            lblDataViagem.Text = "Data Viagem:"
            ' 
            ' txtDataViagem
            ' 
            txtDataViagem.Location = New System.Drawing.Point(160, 63)
            txtDataViagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtDataViagem.Name = "txtDataViagem"
            txtDataViagem.ReadOnly = True
            txtDataViagem.Size = New System.Drawing.Size(457, 27)
            txtDataViagem.TabIndex = 3
            ' 
            ' lblRota
            ' 
            lblRota.AutoSize = True
            lblRota.Location = New System.Drawing.Point(17, 109)
            lblRota.Name = "lblRota"
            lblRota.Size = New System.Drawing.Size(43, 20)
            lblRota.TabIndex = 4
            lblRota.Text = "Rota:"
            ' 
            ' txtRota
            ' 
            txtRota.Location = New System.Drawing.Point(160, 105)
            txtRota.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtRota.Name = "txtRota"
            txtRota.ReadOnly = True
            txtRota.Size = New System.Drawing.Size(457, 27)
            txtRota.TabIndex = 5
            ' 
            ' lblTipoViagem
            ' 
            lblTipoViagem.AutoSize = True
            lblTipoViagem.Location = New System.Drawing.Point(17, 152)
            lblTipoViagem.Name = "lblTipoViagem"
            lblTipoViagem.Size = New System.Drawing.Size(97, 20)
            lblTipoViagem.TabIndex = 6
            lblTipoViagem.Text = "Tipo Viagem:"
            ' 
            ' txtTipoViagem
            ' 
            txtTipoViagem.Location = New System.Drawing.Point(160, 148)
            txtTipoViagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtTipoViagem.Name = "txtTipoViagem"
            txtTipoViagem.ReadOnly = True
            txtTipoViagem.Size = New System.Drawing.Size(457, 27)
            txtTipoViagem.TabIndex = 7
            ' 
            ' lblPlacaCavalo
            ' 
            lblPlacaCavalo.AutoSize = True
            lblPlacaCavalo.Location = New System.Drawing.Point(17, 195)
            lblPlacaCavalo.Name = "lblPlacaCavalo"
            lblPlacaCavalo.Size = New System.Drawing.Size(96, 20)
            lblPlacaCavalo.TabIndex = 8
            lblPlacaCavalo.Text = "Placa Cavalo:"
            ' 
            ' txtPlacaCavalo
            ' 
            txtPlacaCavalo.Location = New System.Drawing.Point(160, 191)
            txtPlacaCavalo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtPlacaCavalo.Name = "txtPlacaCavalo"
            txtPlacaCavalo.ReadOnly = True
            txtPlacaCavalo.Size = New System.Drawing.Size(457, 27)
            txtPlacaCavalo.TabIndex = 9
            ' 
            ' lblPlacaCarreta1
            ' 
            lblPlacaCarreta1.AutoSize = True
            lblPlacaCarreta1.Location = New System.Drawing.Point(17, 237)
            lblPlacaCarreta1.Name = "lblPlacaCarreta1"
            lblPlacaCarreta1.Size = New System.Drawing.Size(111, 20)
            lblPlacaCarreta1.TabIndex = 10
            lblPlacaCarreta1.Text = "Placa Carreta 1:"
            ' 
            ' txtPlacaCarreta1
            ' 
            txtPlacaCarreta1.Location = New System.Drawing.Point(160, 233)
            txtPlacaCarreta1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtPlacaCarreta1.Name = "txtPlacaCarreta1"
            txtPlacaCarreta1.ReadOnly = True
            txtPlacaCarreta1.Size = New System.Drawing.Size(457, 27)
            txtPlacaCarreta1.TabIndex = 11
            ' 
            ' lblPlacaCarreta2
            ' 
            lblPlacaCarreta2.AutoSize = True
            lblPlacaCarreta2.Location = New System.Drawing.Point(17, 280)
            lblPlacaCarreta2.Name = "lblPlacaCarreta2"
            lblPlacaCarreta2.Size = New System.Drawing.Size(111, 20)
            lblPlacaCarreta2.TabIndex = 12
            lblPlacaCarreta2.Text = "Placa Carreta 2:"
            ' 
            ' txtPlacaCarreta2
            ' 
            txtPlacaCarreta2.Location = New System.Drawing.Point(160, 276)
            txtPlacaCarreta2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtPlacaCarreta2.Name = "txtPlacaCarreta2"
            txtPlacaCarreta2.ReadOnly = True
            txtPlacaCarreta2.Size = New System.Drawing.Size(457, 27)
            txtPlacaCarreta2.TabIndex = 13
            ' 
            ' lblPontoOperacional
            ' 
            lblPontoOperacional.AutoSize = True
            lblPontoOperacional.Location = New System.Drawing.Point(17, 323)
            lblPontoOperacional.Name = "lblPontoOperacional"
            lblPontoOperacional.Size = New System.Drawing.Size(135, 20)
            lblPontoOperacional.TabIndex = 14
            lblPontoOperacional.Text = "Ponto Operacional:"
            ' 
            ' txtPontoOperacional
            ' 
            txtPontoOperacional.Location = New System.Drawing.Point(160, 319)
            txtPontoOperacional.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtPontoOperacional.Name = "txtPontoOperacional"
            txtPontoOperacional.ReadOnly = True
            txtPontoOperacional.Size = New System.Drawing.Size(457, 27)
            txtPontoOperacional.TabIndex = 15
            ' 
            ' lblManifestar
            ' 
            lblManifestar.AutoSize = True
            lblManifestar.Location = New System.Drawing.Point(17, 365)
            lblManifestar.Name = "lblManifestar"
            lblManifestar.Size = New System.Drawing.Size(82, 20)
            lblManifestar.TabIndex = 16
            lblManifestar.Text = "Manifestar:"
            ' 
            ' txtManifestar
            ' 
            txtManifestar.Location = New System.Drawing.Point(160, 361)
            txtManifestar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtManifestar.Name = "txtManifestar"
            txtManifestar.ReadOnly = True
            txtManifestar.Size = New System.Drawing.Size(457, 27)
            txtManifestar.TabIndex = 17
            ' 
            ' lblVazia
            ' 
            lblVazia.AutoSize = True
            lblVazia.Location = New System.Drawing.Point(17, 408)
            lblVazia.Name = "lblVazia"
            lblVazia.Size = New System.Drawing.Size(47, 20)
            lblVazia.TabIndex = 18
            lblVazia.Text = "Vazia:"
            ' 
            ' txtVazia
            ' 
            txtVazia.Location = New System.Drawing.Point(160, 404)
            txtVazia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtVazia.Name = "txtVazia"
            txtVazia.ReadOnly = True
            txtVazia.Size = New System.Drawing.Size(457, 27)
            txtVazia.TabIndex = 19
            ' 
            ' lblExecutouOK
            ' 
            lblExecutouOK.AutoSize = True
            lblExecutouOK.Location = New System.Drawing.Point(17, 451)
            lblExecutouOK.Name = "lblExecutouOK"
            lblExecutouOK.Size = New System.Drawing.Size(96, 20)
            lblExecutouOK.TabIndex = 20
            lblExecutouOK.Text = "Executou OK:"
            ' 
            ' txtExecutouOK
            ' 
            txtExecutouOK.Location = New System.Drawing.Point(160, 447)
            txtExecutouOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtExecutouOK.Name = "txtExecutouOK"
            txtExecutouOK.ReadOnly = True
            txtExecutouOK.Size = New System.Drawing.Size(457, 27)
            txtExecutouOK.TabIndex = 21
            ' 
            ' lblErro
            ' 
            lblErro.AutoSize = True
            lblErro.Location = New System.Drawing.Point(17, 493)
            lblErro.Name = "lblErro"
            lblErro.Size = New System.Drawing.Size(39, 20)
            lblErro.TabIndex = 22
            lblErro.Text = "Erro:"
            ' 
            ' txtErro
            ' 
            txtErro.Location = New System.Drawing.Point(160, 489)
            txtErro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            txtErro.Name = "txtErro"
            txtErro.ReadOnly = True
            txtErro.Size = New System.Drawing.Size(457, 27)
            txtErro.TabIndex = 23
            ' 
            ' tabFornecedores
            ' 
            tabFornecedores.Controls.Add(dgvFornecedores)
            tabFornecedores.Location = New System.Drawing.Point(4, 29)
            tabFornecedores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            tabFornecedores.Name = "tabFornecedores"
            tabFornecedores.Size = New System.Drawing.Size(792, 593)
            tabFornecedores.TabIndex = 1
            tabFornecedores.Text = "Fornecedores"
            tabFornecedores.UseVisualStyleBackColor = True
            ' 
            ' dgvFornecedores
            ' 
            dgvFornecedores.AllowUserToAddRows = False
            dgvFornecedores.AllowUserToDeleteRows = False
            dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            dgvFornecedores.BackgroundColor = Drawing.SystemColors.Window
            dgvFornecedores.ColumnHeadersHeight = 29
            dgvFornecedores.Dock = System.Windows.Forms.DockStyle.Fill
            dgvFornecedores.Location = New System.Drawing.Point(0, 0)
            dgvFornecedores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            dgvFornecedores.Name = "dgvFornecedores"
            dgvFornecedores.ReadOnly = True
            dgvFornecedores.RowHeadersWidth = 51
            dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            dgvFornecedores.Size = New System.Drawing.Size(792, 593)
            dgvFornecedores.TabIndex = 0
            ' 
            ' tabDestinatarios
            ' 
            tabDestinatarios.Controls.Add(dgvDestinatarios)
            tabDestinatarios.Location = New System.Drawing.Point(4, 29)
            tabDestinatarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            tabDestinatarios.Name = "tabDestinatarios"
            tabDestinatarios.Size = New System.Drawing.Size(792, 593)
            tabDestinatarios.TabIndex = 2
            tabDestinatarios.Text = "Destinatarios"
            tabDestinatarios.UseVisualStyleBackColor = True
            ' 
            ' dgvDestinatarios
            ' 
            dgvDestinatarios.AllowUserToAddRows = False
            dgvDestinatarios.AllowUserToDeleteRows = False
            dgvDestinatarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            dgvDestinatarios.BackgroundColor = Drawing.SystemColors.Window
            dgvDestinatarios.ColumnHeadersHeight = 29
            dgvDestinatarios.Dock = System.Windows.Forms.DockStyle.Fill
            dgvDestinatarios.Location = New System.Drawing.Point(0, 0)
            dgvDestinatarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            dgvDestinatarios.Name = "dgvDestinatarios"
            dgvDestinatarios.ReadOnly = True
            dgvDestinatarios.RowHeadersWidth = 51
            dgvDestinatarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            dgvDestinatarios.Size = New System.Drawing.Size(792, 593)
            dgvDestinatarios.TabIndex = 0
            ' 
            ' tabPlantas
            ' 
            tabPlantas.Controls.Add(dgvPlantas)
            tabPlantas.Location = New System.Drawing.Point(4, 29)
            tabPlantas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            tabPlantas.Name = "tabPlantas"
            tabPlantas.Size = New System.Drawing.Size(792, 593)
            tabPlantas.TabIndex = 3
            tabPlantas.Text = "Plantas"
            tabPlantas.UseVisualStyleBackColor = True
            ' 
            ' dgvPlantas
            ' 
            dgvPlantas.AllowUserToAddRows = False
            dgvPlantas.AllowUserToDeleteRows = False
            dgvPlantas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            dgvPlantas.BackgroundColor = Drawing.SystemColors.Window
            dgvPlantas.ColumnHeadersHeight = 29
            dgvPlantas.Dock = System.Windows.Forms.DockStyle.Fill
            dgvPlantas.Location = New System.Drawing.Point(0, 0)
            dgvPlantas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            dgvPlantas.Name = "dgvPlantas"
            dgvPlantas.ReadOnly = True
            dgvPlantas.RowHeadersWidth = 51
            dgvPlantas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            dgvPlantas.Size = New System.Drawing.Size(792, 593)
            dgvPlantas.TabIndex = 0
            ' 
            ' FormPrincipal
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(8F, 20F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(800, 693)
            Controls.Add(tabControl)
            Controls.Add(pnlTopo)
            Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            MinimumSize = New System.Drawing.Size(816, 730)
            Name = "FormPrincipal"
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "Duett - Sincronizar"
            pnlTopo.ResumeLayout(False)
            pnlTopo.PerformLayout()
            tabControl.ResumeLayout(False)
            tabViagem.ResumeLayout(False)
            pnlViagem.ResumeLayout(False)
            pnlViagem.PerformLayout()
            tabFornecedores.ResumeLayout(False)
            CType(dgvFornecedores, ComponentModel.ISupportInitialize).EndInit()
            tabDestinatarios.ResumeLayout(False)
            CType(dgvDestinatarios, ComponentModel.ISupportInitialize).EndInit()
            tabPlantas.ResumeLayout(False)
            CType(dgvPlantas, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

        Friend WithEvents pnlTopo As System.Windows.Forms.Panel
        Friend WithEvents lblFone As System.Windows.Forms.Label
        Friend WithEvents txtFone As System.Windows.Forms.TextBox
        Friend WithEvents btnSincronizar As System.Windows.Forms.Button
        Friend WithEvents lblStatus As System.Windows.Forms.Label
        Friend WithEvents tabControl As System.Windows.Forms.TabControl
        Friend WithEvents tabViagem As System.Windows.Forms.TabPage
        Friend WithEvents pnlViagem As System.Windows.Forms.Panel
        Friend WithEvents lblNumeroViagem As System.Windows.Forms.Label
        Friend WithEvents txtNumeroViagem As System.Windows.Forms.TextBox
        Friend WithEvents lblDataViagem As System.Windows.Forms.Label
        Friend WithEvents txtDataViagem As System.Windows.Forms.TextBox
        Friend WithEvents lblRota As System.Windows.Forms.Label
        Friend WithEvents txtRota As System.Windows.Forms.TextBox
        Friend WithEvents lblTipoViagem As System.Windows.Forms.Label
        Friend WithEvents txtTipoViagem As System.Windows.Forms.TextBox
        Friend WithEvents lblPlacaCavalo As System.Windows.Forms.Label
        Friend WithEvents txtPlacaCavalo As System.Windows.Forms.TextBox
        Friend WithEvents lblPlacaCarreta1 As System.Windows.Forms.Label
        Friend WithEvents txtPlacaCarreta1 As System.Windows.Forms.TextBox
        Friend WithEvents lblPlacaCarreta2 As System.Windows.Forms.Label
        Friend WithEvents txtPlacaCarreta2 As System.Windows.Forms.TextBox
        Friend WithEvents lblPontoOperacional As System.Windows.Forms.Label
        Friend WithEvents txtPontoOperacional As System.Windows.Forms.TextBox
        Friend WithEvents lblManifestar As System.Windows.Forms.Label
        Friend WithEvents txtManifestar As System.Windows.Forms.TextBox
        Friend WithEvents lblVazia As System.Windows.Forms.Label
        Friend WithEvents txtVazia As System.Windows.Forms.TextBox
        Friend WithEvents lblExecutouOK As System.Windows.Forms.Label
        Friend WithEvents txtExecutouOK As System.Windows.Forms.TextBox
        Friend WithEvents lblErro As System.Windows.Forms.Label
        Friend WithEvents txtErro As System.Windows.Forms.TextBox
        Friend WithEvents tabFornecedores As System.Windows.Forms.TabPage
        Friend WithEvents dgvFornecedores As System.Windows.Forms.DataGridView
        Friend WithEvents tabDestinatarios As System.Windows.Forms.TabPage
        Friend WithEvents dgvDestinatarios As System.Windows.Forms.DataGridView
        Friend WithEvents tabPlantas As System.Windows.Forms.TabPage
        Friend WithEvents dgvPlantas As System.Windows.Forms.DataGridView
    End Class
End Namespace
