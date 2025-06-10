### CIGAM
## 🧠 Arquitetura e Camadas do Projeto

Este projeto segue uma arquitetura em **camadas**, com separação clara de responsabilidades, facilitando a manutenção, testes e evolução da aplicação.

---

### 📐 Camadas da Aplicação

| Camada              | Responsabilidade                                                                 | Classes / Interfaces                      |
|---------------------|-----------------------------------------------------------------------------------|--------------------------------------------|
| **UI (Interface)**   | Interface gráfica (Forms). Recebe ações do usuário e exibe resultados.           | `FormCliente` (não incluído aqui, mas esperado) |
| **Service Layer**    | Camada de regras de negócio. Orquestra as ações entre a UI e o repositório.      | `ClienteService`                           |
| **Repository Layer** | Responsável por acessar diretamente o banco de dados (CRUD).                     | `ClienteRepository`, `IClienteRepository`  |
| **Domain / Model**   | Representa as entidades de domínio da aplicação.                                 | `Cliente`                                   |
| **Contracts**        | Interface que define os contratos de acesso a dados (Repository).                | `IClienteRepository`                       |

---

### 🔁 Fluxo de Execução

Exemplo: **Salvar um cliente**

1. A UI (formulário) chama `ClienteService.Salvar(cliente)`.
2. O `ClienteService` verifica se é um novo cliente (código = 0) ou uma atualização.
3. Ele chama o método apropriado (`Inserir` ou `Atualizar`) no repositório (`IClienteRepository`).
4. O `ClienteRepository` executa o SQL no banco de dados via OleDb.
5. O resultado é devolvido, e a UI pode notificar o usuário.

---

### ✅ Benefícios da Arquitetura

- **Baixo acoplamento:** Cada camada conhece apenas a imediatamente inferior.
- **Alta coesão:** Cada classe tem uma única responsabilidade.
- **Facilidade de testes:** É possível simular o repositório (mock) e testar regras de negócio sem banco de dados real.
- **Flexibilidade:** É possível trocar o banco de dados (Access, SQL Server, etc) sem alterar o restante do código, bastando implementar a interface `IClienteRepository`.

---

### 📦 Estrutura de Pastas Sugerida

/Projeto
│
├── Models
│ └── Cliente.vb
│
├── Services
│ └── ClienteService.vb
│
├── Repositories
│ ├── IClienteRepository.vb
│ └── ClienteRepository.vb
│
├── Forms
│ └── FormCliente.vb (UI)
│
├── Utils
│ └── ConnectionString.vb
│
└── README.md

---

### 💡 Observações

- O projeto utiliza `OleDbConnection` para conexão com banco de dados Access, mas pode ser adaptado para outros SGBDs.
- O campo `CODIGO` é considerado a **chave primária** da tabela `CLIENTE`.
- Regras como validação de CPF, prevenção de duplicidades e transações podem ser adicionadas na camada `Service` para maior robustez.

---


