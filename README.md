# 🚛 Teste Técnico - Duett

Aplicação desenvolvida como parte do processo seletivo da **Duett**.

O projeto consiste em um cliente **Windows Forms (VB.NET)** que realiza a sincronização de dados através de uma API REST, processa a resposta em formato JSON e apresenta as informações em uma interface gráfica.

---

## ✨ Funcionalidades

* 📱 Informar o telefone para autenticação da requisição.
* 🔄 Realizar a sincronização através do serviço HTTP.
* 📦 Exibir os dados da viagem:

  * Número da viagem
  * Data
  * Rota
  * Tipo da viagem
  * Placas dos veículos
  * Ponto operacional
  * Status da sincronização
* 🏭 Listar as plantas retornadas pela API.
* 🚚 Exibir fornecedores e destinatários em tabelas.
* ⚠️ Exibir mensagens de erro quando necessário.

---

## 🛠 Tecnologias Utilizadas

* **VB.NET**
* **Windows Forms**
* **.NET Framework**
* **HttpClient**
* **Newtonsoft.Json**

---

## ▶️ Como Executar

1. Abra a solução no **Visual Studio**.
2. Restaure os pacotes NuGet (caso necessário).
3. Compile o projeto.
4. Execute a aplicação.
5. Informe o telefone desejado.
6. Clique em **Sincronizar** para realizar a consulta.

---

## 📂 Estrutura

* **FormPrincipal** — Interface principal da aplicação.
* **PreencherViagem()** — Carrega os dados gerais da viagem.
* **PreencherGridParadas()** — Popula as tabelas de fornecedores e destinatários.
* **PreencherGridPlantas()** — Exibe a lista de plantas retornadas pela API.

---

## 📌 Objetivo

O objetivo deste projeto é demonstrar a integração entre uma aplicação desktop e um serviço web, realizando o consumo de uma API, processamento de dados em JSON e apresentação das informações de forma organizada ao usuário.

---

## 👨‍💻 Autor

**Vinicius Guedes**

Desenvolvido como parte do teste técnico para a **Duett**.
