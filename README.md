# 📚 BibliotecaApi

API REST para gerenciamento de biblioteca, desenvolvida com .NET 10, C# e MongoDB.

---

## 📋 Domínio

O sistema permite gerenciar **Livros** e **Empréstimos** de uma biblioteca, com operações completas de CRUD para cada entidade.

---

## 🛠️ Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

---

## 🚀 Como executar o projeto

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
http://localhost:5078/index.html

---

## 📖 Documentação Swagger

Com a aplicação rodando, acesse:
http://localhost:5078/swagger

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

## 🏗️ Arquitetura

O projeto segue arquitetura em camadas:
Controllers → Services → Repositories → MongoDB

- **Controllers** — recebem e respondem requisições HTTP
- **Services** — contêm as regras de negócio
- **Repositories** — acessam o banco de dados
- **Models** — definem a estrutura dos dados
- **DTOs** — objetos de entrada e saída da API

---
BibliotecaApi/
├── Controllers/              # Camada de apresentação (API)
│   ├── LivrosController.cs
│   └── EmprestimoController.cs
│
├── Services/                 # Regras de negócio
│   ├── LivroService.cs
│   ├── EmprestimoSevice.cs
│   ├── ILivrosService.cs
│   └── IEmprestimoService.cs
│
├── Repositories/             # Acesso a dados (MongoDB)
│   ├── LivrosRepositorios.cs
│   ├── EmprestimoRepositorios.cs
│   ├── IlivrosRepositorios.cs
│   └── IEmprestimoRepositorios.cs
│
├── Models/                   # Entidades do domínio
│   ├── livros.cs
│   └── emprestimos.cs
│
├── wwwroot/                  # Arquivos estáticos (Frontend)
│   └── index.html
│
├── Properties/
├── bin/ e obj/               # Pastas geradas
├── appsettings.json
├── appsettings.Development.json
├── BibliotecaApi.csproj
├── Program.cs
├── docker-compose.yml
└── README.md

## 🧪 Testando a API

Use o Swagger em `http://localhost:5078/swagger` para testar todos os endpoints disponíveis.
