### CIGAM - PROJETO EM VB
## 🧠 Arquitetura e Camadas do Projeto

Este projeto segue uma arquitetura em **camadas**, com separação clara de responsabilidades, facilitando a manutenção, testes e evolução da aplicação.

---

### 🔁 Fluxo de Execução

Exemplo: **Salvar um cliente**

1. A UI (formulário) chama `ClienteService.Salvar(cliente)`.
2. O `ClienteService` verifica se é um novo cliente (código = 0) ou uma atualização.
3. Ele chama o método apropriado (`Inserir` ou `Atualizar`) no repositório (`IClienteRepository`).
4. O `ClienteRepository` executa o SQL no banco de dados via OleDb.
5. O resultado é devolvido, e a UI pode notificar o usuário.

---

### 🚀 Como Executar

### 1. Clonar o repositório

```bash
git clone https://github.com/invazing/CIGAM
```

## 2. Apontar o banco de dados

Altere a String de conexão do banco de dados `ConnectionString.vb`:

Módulo que guarda a string de conexão com o banco de dados Access

    ' Public ReadOnly StringConexao As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\CIGAM\CIGAM\Database.accdb;"

## 3. Rodar o projeto

Abra a solução no Visual Studio 2022, compile e pressione F5 para executar.

---

### 📦 Estrutura de Pastas

```text
/Domain
│
├── Application
│   └── ClienteService.vb  (CAMADA DE SERVIÇOS)
│
├── Data
│   └── ClienteRepository.vb  (CAMADA DE BANCO)
│
├── Entities
│   └── Cliente.vb  (CAMADA DE CLASSE)
│
├── Interfaces
│   └── IClienteRepository.vb (CAMADA DE INTERFACE)
│
├── Infrastructure  (STRING DE CONEXÃO)
│   └── ConnectionString 
│
├── Resources  (CAMADA DE RECURSO)
│   └── lapis.png  
│
└── WinFormsUI  (CAMADA DE FORMS)
    └── frmClienteCadastro.vb
    └── frmClientePesquisa.vb
```

---

### 💡 Observações

- O projeto utiliza `OleDbConnection` para conexão com banco de dados Access, mas pode ser adaptado para outros SGBDs.
- O campo `CODIGO` é considerado a **chave primária** da tabela `CLIENTE`.

---

![image](https://github.com/user-attachments/assets/8ed5833c-3259-47a9-9538-e43923500028)



