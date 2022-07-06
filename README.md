<h1 align="center">

Calculadora Jurídica - Back End    <img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=RED&style=for-the-badge"/>

</h1>


## Manual Backend [ambiente Windows]

### 1. Pré-requisitos
    
    - [SQLServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads/)
    - [SSMS](https://aka.ms/ssmsfullsetup/)
    - [GIT](https://git-scm.com/download/win/)

## 🎲 Rodando o banco


### 2. Criando e populando Banco de dados
    2.1 Abra o SSMS
    2.2 Faça login no Sql Server Studio clicando em "Connect"
        Server type = Database Engine
        Server name = localhost
        Autentication = Windows Authentication
        (conexao com o banco - back está no arquivo Startup.cs na linha 61)

    2.3 Clique com o botão secundário no nome do servidor e selecione a opção "New Query"
    2.4 Copie o conteúdo do arquivo criando-tabelas.sql que tá no back e cole nesse arquivo "New Query" do SSMS
    2.5 Faça o mesmo com o arquivo indices-ALL.sql

## 🛠 Rodando o back - dotnet

### 5. Baixe o projeto usando um terminal

```
git clone https://juliano_sts@bitbucket.org/juliano_sts/calculadora-back.git

```
```
cd calcadora-back
```
```
git checkout release_v2
```

```
dotnet run
```

Caso precise instalar manualmente os pacotes
```
dotnet tool install --global dotnet-ef --version 3.0.3
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.3
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.5
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.0.3
dotnet add package Microsoft.AspNetCore.Authentication --version 2.2.0
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 3.0.0
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.0.3
dotnet add package X.PagedList --version 3.0.3

```

** No terminal deve aparecer o projeto rodando http://localhost:5000 / https://localhost:5001

5.1 Tente acessar a url de Indices: https://localhost:5001/api/indices :

```
{
    "draw": 1,
    "recordsTotal": 0,
    "data": []
}
```