# FIAP Cloud Games

## Grupo - 48

- Roberto Lima de Moura - RM364393 - roblm_@hotmail.com
- Ricardo Zitelli de Oliveira - RM 360730 - ricardo_zitelli@hotmail.com
- Victor Prado Chaves - RM362764 - vicpradochaves@gmail.com

## Requisitos Funcionais

- **Cadastro de usu�rios**: Identifica��o do cliente por nome, e-mail e senha, e Validar formato de e-mail e senha segura (m�nimo de 8 caracteres com n�meros, letras e caracteres especiais).
- **Autentica��o e Autoriza��o**: Autentica��o via token JWT. Ter dois n�veis de acesso: Usu�rio e Administrador

## Requisitos T�cnicos

- Desenvolvimento de API com .NET 8.
- Entity Framework Core para gerenciar os modelos de usu�rios e jogos.
- Aplicar migrations para a cria��o do banco de dados.
- Utiliza��o do MSSQL como banco de dados.
- API seguindo o padr�o Controllers MVC.
- Implementar Middleware para tratamento de erros e logs estruturados.
- Documenta��o com Swagger para expor os endpoints da API.
- Tratamento de erros e sistema de logs no banco de dados
- Testes unit�rios com xUnit

## DDD - Event Storming

[Diagrama de Envent Storm de cadastro de Usu�rio e Cadastro de Jogos no Miro](https://miro.com/app/board/uXjVIxoFegg=/)

## Setup do Banco de Dados e Migra��es

- Crie um banco de dados chamado "fiapcloudgames" no seu banco de dados local
- Quando o projeto for executado, ele far� as migra��es automaticamente para o banco de dados
- Nesta migra��o inicial tamb�m ser� criado um usu�rio administrador

## String de Conex�o

- Alterar a string de conex�o no arquivo "appsettings.json" para o seu servidor local
