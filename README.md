# 📚 BibliotecaApi

API REST para gerenciamento de biblioteca, desenvolvida com .NET 10, C# e MongoDB.

---

## 📋 Domínio

O sistema permite gerenciar **Livros** e **Empréstimos** de uma biblioteca, com operações completas de CRUD para cada entidade.

---

## 🛠️ Tecnologias Utilizadas

| Camada | Tecnologia | Descrição |
|---|---|---|
| Backend | C# com .NET 10 | Linguagem e plataforma principal da API |
| Banco de Dados | MongoDB 7.0 | Banco de dados NoSQL para persistência |
| Container | Docker + Docker Compose | Orquestração do MongoDB em container |
| Documentação | Swagger / OpenAPI | Documentação e teste dos endpoints |
| Frontend | HTML + JavaScript | Interface web com navegação assíncrona |
| Versionamento | Git + GitHub | Controle de versão e repositório remoto |

---

## 🏗️ Arquitetura

O projeto segue arquitetura em camadas:

```
Requisição HTTP
      ↓
  Controller        → recebe e responde requisições HTTP
      ↓
   Service          → contém as regras de negócio
      ↓
  Repository        → acessa o banco de dados
      ↓
   MongoDB          → persiste os dados
```

---

## 📁 Estrutura do Projeto

```
bibliotecaApi/
├── Controllers/
│   ├── LivrosController.cs         # Endpoints HTTP de Livros
│   └── EmprestimoController.cs     # Endpoints HTTP de Empréstimos
├── Models/
│   ├── Livros.cs                   # Modelo de dados do Livro
│   └── Emprestimo.cs               # Modelo de dados do Empréstimo
├── Services/
│   ├── ILivroService.cs            # Interface do serviço de Livros
│   ├── LivroService.cs             # Regras de negócio de Livros
│   ├── IEmprestimoService.cs       # Interface do serviço de Empréstimos
│   └── EmprestimoService.cs        # Regras de negócio de Empréstimos
├── Repositories/
│   ├── IlivrosRepositorios.cs      # Interface do repositório de Livros
│   ├── LivrosRepositorios.cs       # Acesso ao MongoDB - Livros
│   ├── IEmprestimoRepositorios.cs  # Interface do repositório de Empréstimos
│   └── EmprestimoRepositorios.cs   # Acesso ao MongoDB - Empréstimos
├── DTOs/                           # Objetos de entrada e saída da API
├── wwwroot/
│   └── index.html                  # Frontend com navegação assíncrona
├── appsettings.json                # Configurações da aplicação
├── appsettings.Development.json    # Configurações de desenvolvimento
├── Program.cs                      # Ponto de entrada da aplicação
├── BibliotecaApi.csproj            # Configuração do projeto .NET
docker-compose.yml                  # Orquestração do MongoDB
README.md                           # Documentação do projeto
SOLID.md                            # Documentação dos princípios SOLID
```

---

## 🚀 Como executar o projeto

### Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

### 1. Clone o repositório

```bash
git clone https://github.com/adailcdev-tech/BibliotecaApi.git
cd BibliotecaApi
```

### 2. Suba o MongoDB com Docker

```bash
docker-compose up -d
```

### 3. Execute a API

```bash
cd bibliotecaApi
dotnet run
```

### 4. Acesse o frontend

```
http://localhost:5078/index.html
```

---

## 📖 Documentação Swagger

Com a aplicação rodando, acesse:

```
http://localhost:5078/swagger
```

---

## ⚙️ Variáveis de Ambiente

As configurações do banco ficam no `appsettings.json`:

```json
{
  "MongoDBSettings": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "bibliotecaDb"
  }
}
```

> Em produção, substitua a `ConnectionString` pela variável de ambiente correspondente.

---

## 📌 Endpoints disponíveis

### Livros

| Método | Endpoint | Descrição |
|---|---|---|
| GET | /api/livros | Lista todos os livros |
| GET | /api/livros/{id} | Busca livro por ID |
| POST | /api/livros | Cadastra novo livro |
| PUT | /api/livros/{id} | Atualiza livro |
| DELETE | /api/livros/{id} | Remove livro |

### Empréstimos

| Método | Endpoint | Descrição |
|---|---|---|
| GET | /api/emprestimos | Lista todos os empréstimos |
| GET | /api/emprestimos/{id} | Busca empréstimo por ID |
| POST | /api/emprestimos | Cadastra novo empréstimo |
| PUT | /api/emprestimos/{id} | Atualiza empréstimo |
| DELETE | /api/emprestimos/{id} | Remove empréstimo |

---
BibliotecaApi/
├── Controllers/              
│   ├── LivrosController.cs
│   └── EmprestimoController.cs
│
├── Services/                 
│   ├── LivroService.cs
│   ├── EmprestimoSevice.cs
│   ├── ILivrosService.cs
│   └── IEmprestimoService.cs
│
├── Repositories/            
│   ├── LivrosRepositorios.cs
│   ├── EmprestimoRepositorios.cs
│   ├── IlivrosRepositorios.cs
│   └── IEmprestimoRepositorios.cs
│
├── Models/                   
│   ├── livros.cs
│   └── emprestimos.cs
│
├── wwwroot/                 
│   └── index.html
│
├── Properties/
├── bin/ e obj/               
├── appsettings.json
├── appsettings.Development.json
├── BibliotecaApi.csproj
├── Program.cs
├── docker-compose.yml
└── README.md

## 🧪 Testando a API

Use o Swagger em `http://localhost:5078/swagger` para testar todos os endpoints disponíveis.
