# 🚀 Next Level Week - Rocketseat

![Badge](https://img.shields.io/badge/Status-Concluído-green)  
![Badge](https://img.shields.io/badge/Framework-.NET-blue)  
![Badge](https://img.shields.io/badge/Language-C%23-purple)  

Projeto desenvolvido durante a **Next Level Week (NLW)** da **Rocketseat**, ministrada pelo professor **Wellysson**.  
Este projeto aborda a criação de uma **API segura e eficiente** utilizando **C# e .NET**, com autenticação JWT, criptografia de senhas e integração com banco de dados.  

## 📌 Tecnologias Utilizadas  

- **C#**  
- **.NET Core**  
- **Entity Framework**  
- **JWT para autenticação**  
- **BCrypt para criptografia de senhas**  
- **Banco de dados SQL Server**  
- **Swagger para documentação da API**  

## 📋 Funcionalidades  

✅ Cadastro e autenticação de usuários  
✅ Criptografia de senhas com BCrypt  
✅ Implementação de **tokens JWT** para autenticação segura  
✅ Integração com **banco de dados SQL Server** usando Entity Framework  
✅ Tratamento adequado de **exceções personalizadas**  
✅ Implementação de **paginação e filtros** para otimizar a busca de dados  

## 📦 Instalação e Configuração  

### 1️⃣ Clonar o repositório  
```bash
git clone https://github.com/FernandoZuchi/nlw-connect-csharp.git
cd nlw-dotnet-api
```

### 2️⃣ Configurar o banco de dados  
Certifique-se de ter um banco de dados **SQL Server** rodando. No arquivo `appsettings.json`, configure a string de conexão:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=SEU_BANCO;User Id=SEU_USUARIO;Password=SUA_SENHA;"
}
```

### 3️⃣ Restaurar as dependências  
```bash
dotnet restore
```

### 4️⃣ Aplicar as migrations e atualizar o banco de dados  
```bash
dotnet ef database update
```

### 5️⃣ Rodar a aplicação  
```bash
dotnet run
```

A API estará disponível em `http://localhost:7101` 🚀  

## 🛠 Endpoints Principais  

### 🔹 Autenticação  
- `POST /auth/register` → Cadastra um novo usuário  
- `POST /auth/login` → Realiza login e retorna um token JWT  

### 🔹 Usuários  
- `GET /users` → Retorna a lista de usuários cadastrados  
- `GET /users/{id}` → Retorna um usuário específico  
- `PUT /users/{id}` → Atualiza um usuário  
- `DELETE /users/{id}` → Remove um usuário  

### 🔹 Documentação da API  
A documentação completa pode ser acessada via **Swagger**:  
```
http://localhost:7101/swagger/index.html
```

## 📜 Licença  
Este projeto foi desenvolvido para fins educacionais na **Next Level Week (NLW)** da Rocketseat.  
---

🔗 **Conecte-se comigo no LinkedIn**: [Fernando Zuchi](https://www.linkedin.com/in/fernando-zuchi-ozorio-87350b269/overlay/contact-info/)  

💡 **Gostou do projeto? Deixe uma ⭐ no repositório!**
