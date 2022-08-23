<h1>Aplicando testes com xUnit</h1>

Em C#, usamos o xUnit, ferramenta baseada no NUnit v2, para criar nossos testes de unidade. Atualmente, é uma ferramenta muito adotada para criação de testes de unidade no framework .NET Core, sendo usado em C#, F# e Visual Basic. Além disso, possui suporte a todos os frameworks .NET.

Contruindo teste seguindo as seguintes premissas:

1. Obter uma funcionalidade para testar
2. Pensar em como essa funcionalidade deveria ser
3. Escrever um teste que garanta esse comportamento

Para criar um projeto .NET do tipo xUnit: 

`dotnet new xunit -o <Nome do projeto>`

✏️:Crie o nome do projeto de testes com o mesmo nome do projeto original, adicione somente o sufixo .Test para diferenciar.

Exemplo: 

Código que testa a funcionalidade de soma:

```
public static int Sum(int number1, int number2) 
{
    var result = number1 + number2;
    return result;
}
```
casos de soma, exemplo: 3 + 3 = 6, -10 + 3 = -7 ou 77 + 33 = 110

```
Sum(3, 3) // deve retornar 6
Sum(-10, 3) // deve retornar -7
Sum(77, 33) // deve retornar 110
```
```
[Fact]
public void TestSum()
{
    Assert.Equal(Sum(77, 33), 110);
}
```

✏️: No xUnit, a palavra Assert representa uma premissa que deve ser verdadeira para o teste passar; caso seja falsa, o teste falha. Foi usado o .Equal(), para comparar se a Sum(77, 33) é igual ao seu resultado esperado 110.

O `FluentAssertions` é uma biblioteca com muitos métodos de extensão para testes no ambiente .NET, ou seja, ela ajuda a escrever melhor os testes, tornando-os mais legíveis, mais fáceis de entender e modificar, além de melhorar as mensagens de erro.

Para adicionar o FluentAssertions em um projeto .NET do tipo xUnit, use o comando DENTRO da pasta nomeDoProjeto.Test:

` dotnet add package FluentAssertions --version 6.5.1`

Para confirmar que a biblioteca foi importada pelo NuGet, use o comando:

`dotnet restore`

Reescrevendo o teste anterior:

```
[Fact]
public void TestSumFluent()
{
    result = Sum(77, 33)
    result.Should().Be(110)
}
```

Primeiro usamos a função que será testada Sum(), com os valores que sabemos. Em seguida, dizemos através de funções bem separadas o que será testado, por exemplo a função Should()(traduzida como Deve em português). Essa função nos diz que esse resultado deve alguma coisa, que será complementado pela função Be(), ou seja, esse resultado deve ser 110.

Caso esse teste falhasse, seria exibido algo como

*_Expected result to be 110, but 100 differs near 10 (index 0)_*

[Clique aqui](https://fluentassertions.com/introduction) para visitar a documentação do FluentAssertions

<h2>Data annotations</h2>

No xUnit, os data annotations são marcadores que usamos para:(I) identificar os testes; (II) descrevê-los ou (III) passar parâmetros para a função.

Exemplo: 

[Fact] É invariante quanto aos parâmetros de entrada, ou seja, os dados que usamos para testar nunca irão mudar.

```
[Fact]
public void TestSumFluent()
{
    result = Sum(77, 33)
    result.Should().Be(110)
}
```

✏️: Utilizando o [Fact] na estrutura do seu código, você pode executar inúmeras vezes esse teste TestSumFluent(). Ele sempre testará com os valores 77 e 33 e sempre esperará a resposta como 110.

[Theory] Ele também indica que uma função é um teste, porém, nos permite passar diversos valores para a função de teste utilizando outra data annotation chamada de [InLineData()]. Assim, conseguimos escrever um teste de forma generalista e alternar os parâmetros usando o [InLineData()]. Em outras palavras, com o [InLineData()] é possível dizer que é aceito as variações expecificadas.

```
[Theory]
[InlineData(3, 3, 6)]
[InlineData(-10, 3, -7)]
[InlineData(77, 33, 110)]
public void TestSumFluent(int entry1, int entry2, int expected)
{
    result = Sum(entry1, entry2)
    result.Should().Be(expected)
}
```

No exemplo acima, a função de teste TestSumFluent() será executada 3 vezes, 1 para cada [InLineData()] que for adicionado.

Para deixarmos a legibilidade do nosso teste ainda melhor, podemos explicitar como o teste será escrito no terminal da pessoa programadora por meio do DisplayName, desse modo:

```
[Theory(DisplayName = "Deve somar corretamente as entradas.")]
[InlineData(3, 3, 6)]
public void TestSumFluent(int entry1, int entry2, int expected)
{
    result = Sum(entry1, entry2)
    result.Should().Be(expected)
}
```

Para execução todos os teste rodar o comando:

`dotnet test`

Para executar um teste expecífico basta executar o comando: 
 `dotnet test --filter Name~TestMethod1`
 
*Outras opções para testes*

`-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
`-t|--list-tests`: lista todos os testes ao invés de executá-los.
`-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
`q | quiet`
`m | minimal`
`n | normal`
`d | detailed`
`diag | diagnostic`
Exemplo de uso:
```
  dotnet test -v diag
```
ou
```
  dotnet test --verbosity=diagnostic
```

<h2>Explorando os tipos de testes</h2>

*Testes Unitários*

Imagine uma aplicação completa. Agora, pense que essa aplicação pode ser divida em partes menores.
obs: Em C# essas partes menores são chamadas de Funções!

Os testes unitários, ou testes de unidade, têm o objetivo de verificar o comportamento da menor unidade que compõe uma aplicação.

Principais motivos para o uso dos testes unitários:

1- Testar códigos pequenos é mais fácil do que testar códigos grandes;
2- Dividindo a aplicação em partes, fica nítida a divisão de responsabilidades da aplicação e dos testes;
3- Se algum teste unitário falha, a pessoa desenvolvedora saberá exatamente onde está o problema.

*Testes de Integração*

Com os testes unitários garantindo o funcionamento das menores partes, podemos integrar essas partes. Os testes de integração têm o objetivo de verificar o comportamento em grupo das partes que foram testadas de forma separada, para que assim possam compor a aplicação.

Principais motivos para o uso dos testes de integração:

1- É essencial garantir que a aplicação funciona;
2- É importante garantir que modificações nas pequenas partes não quebram a aplicação quando integrada; -Testando o agrupamento das partes unitárias, você consegue verificar a modularidade de sua aplicação;
3- Servem também como documentação para auxiliar novos membros da equipe de desenvolvimento a entender a aplicação.
