<h1>Criando projetos .NET com a CLI</h1>

**Criando aplicação simples de console**

Aplicações de console são aquelas que não possuem interface gráfica (GUI) e cuja forma de comunicação com a pessoa usuária é por meio do console (Prompt de Comando).

`dotnet new console -o <nome da pasta>`

**Executando código C#**

o .NET fornece um jeito rápido e prático para compilar código utilizando a CLI. De dentro da pasta de um projeto execute:

`dotnet build`

Esse comando vai gerar um programa executável de seu projeto e armazenar na pasta bin/

Para executar esse código, basta rodar o comando:

`dotnet run`

Esse comando vai executar a aplicação no mesmo terminal em que você executou o comando dotnet run.

<h2>Criando outros tipos de aplicações .NET</h2>

Existem vários modelos disponíveis para utilizar com o comando new e criar um projeto. Você pode listar todos os modelos pré-configurados disponíveis com o comando:

`dotnet new -l`

<h2>Criando projeto Web API</h2>

`dotnet new webapi -o <nomeDoProjeto>`

<h2>Criando projeto MVC</h2>

`dotnet new mvc -o <nomeDoProjeto>`

<h2>Criando projeto de biblioteca</h2>

`dotnet new classlib -o <nomeDoProjeto>`

<h2>Criando um projeto de testes unitários</h2>

`dotnet new xunit`

