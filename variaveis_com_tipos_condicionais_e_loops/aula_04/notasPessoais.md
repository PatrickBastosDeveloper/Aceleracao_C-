<h2>Estruturas de repetição</h2>
Obs: Exemplos na pasta ex-loops.

Em determinadas situações precisaremos executar repetidamente um trecho de código, até que determinada condição seja atendida. Para que isso ocorra, devemos utilizar instruções de iteração também chamadas de instruções de repetição, como while, do/while, for e foreach.

<h2>Instrução while</h2>

A instrução while testa uma expressão booleana especificada e, enquanto essa expressão for verdadeira, fará a execução de um bloco de instruções.

A instrução while testa uma expressão booleana especificada e, enquanto essa expressão for verdadeira, fará a execução de um bloco de instruções.

```

while (condição)
{
   //bloco de código a ser executado quando a condição for VERDADEIRA    
    comandos;

}

```

Exemplo1:

```
var count = 0;
while (count < 10)
{
    Console.WriteLine("count " + count);
    count++;
}

```

No exemplo acima, o while testará a variável count antes de executar seu bloco de instruções. A rotina repetirá esse bloco de instruções até que count fique com valor igual a dez, dessa forma a condição não será mais verdadeira e o loop deixará de ser executado.

<h2>Instrução do/while</h2>

A instrução de repetição do/while fará primeiro a execução de um bloco de instruções para depois avaliar a expressão booleana especificada, e quando essa expressão for verdadeira, voltará ao início do bloco.

Exemplo2:

```
var count = 0;
do
{
    Console.WriteLine("count " + count);
    count++;
}
while (count < 10);
```

Note que, no exemplo anterior, o do/while testará a variável count após executar a primeira vez seu bloco de instruções. A rotina repetirá esse bloco de instruções até que count fique com valor igual a dez, dessa forma a condição não será mais verdadeira, e o loop deixará de ser executado.

Obs ✏️: A instrução While testa a variável antes de executar o bloco de instruções. Já a instruçãodo/while executa o bloco de instruções antes de avaliar a variável proposta.

<h2>Instrução for</h2>

A instrução de repetição for é composta por três expressões separadas por ponto e vírgula (;). Observe a sintaxe a seguir:

```
for (inicialização; condição; incremento)
{
    //comandos;
}
```

* A primeira expressão é a de inicialização. As variáveis inicializadas no cabeçalho for ficam disponíveis somente no escopo do loop, ou seja, somente dentro do código de iteração do loop.

* A segunda expressão é a condição para a execução da iteração do laço. Na primeira execução do loop, a condição é testada após a inicialização, nas demais iterações a condição é testada após o incremento.

* A terceira expressão é responsável por fazer a iteração da variável. Essa expressão é executada ao final do bloco de instruções e antes da verificação da condição do loop. Vamos observar o funcionamento dessas três expressões no exemplo a seguir:

Exemplo3:

```
for (int count = 0; count < 3; count++)
{
    Console.WriteLine("numero: " + count);
}
```
```
// saída da função
numero: 0
numero: 1
numero: 2
```
No exemplo acima, a variável count é inicializada com valor 0, e o bloco de instrução do for será executado com a condição de count ser menor que 3. Em cada iteração do loop ainda haverá o incremento da variável count.

<h2>Instrução foreach</h2>

```
foreach (tipo elemento in coleção)
{
    //comandos;
}
```
Na declaração do foreach, temos a inicialização de uma variável do mesmo tipo da coleção, o operador in, a coleção que o laço percorrerá e o bloco de instruções a ser executado. A cada incremento do laço, um elemento da coleção será atribuído ao elemento inicalizado na declaração e então o bloco de instruções será executado.

Exemplo4:

```
string[] names = new string[] { "Hulk", "Thor", "Loki" };
foreach (var name in names)
{
    Console.WriteLine(name);
}
```

<h2>Instruções de uma única linha</h2>

No C#, um bloco de instrução é sempre escrito entre chaves {} para delimitar seu contexto. Porém, o uso das chaves não é obrigatório para definir uma instrução de uma linha como ocorre em: for, foreach e while.

Exemplos de intruções em uma única linha:

```
for (int count = 0; count < 10; count++)
    Console.WriteLine(count);
```
```
int[] numbers = new int[] { 1, 2, 3, 4 };
var sum = 0;
foreach (var number in numbers)
    sum += number;
```
```
var isClosed = false;
while (!isClosed)
    isClosed = CloseConnection();
```

<h2>Instruções break</h2>

A instrução break, como o próprio nome já diz, é utilizada para interromper a execução de um laço de repetição (for, foreach, do\while e while). Veja como funciona no exemplo a seguir:

Exemplo 5
```
string[] teachers = new string[] { "Joel", "Tess", "Marlene" };
string[] students = new string[] { "Ellie", "Joel", "Abby" };
foreach (var teacher in teachers)
{
    Console.WriteLine("Professor: " + teacher + ". Estudante:");
    foreach (var student in students)
    {               
        if (teacher == student)
            break;
        Console.WriteLine(student);
    }
}  
```
<h2>Instruções continue</h2>

A instrução continue é utilizada para saltar uma iteração de um laço de repetição (for, foreach, do\while ewhile).

Exemplo 6

```
int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2};
var count = 0;
foreach (var vote in votes)
{                    
    if (vote > 3)
        continue;
    count++;    
}  
Console.WriteLine(count + ' votos válidos');
```

Obs: Mais exercícios no diretório workTools

<h2>Testando saídas e entradas no Console</h2>

Imagine que temos que testar uma aplicação que recebe um nome (string) e imprime uma mensagem de olá para a pessoa:

```
namespace xpt;
public class SayMeHello
{
    public static void Hello(string name)
    {
        Console.WriteLine($"Hey, Hello {name}");
    }
}

```



```
using Xunit;
using FluentAssertions;
using xpt;
namespace xpt.test;
public class TestSayMeHello
{
    [Theory]
    [InlineData("Rahel", "Hey, Hello Rahel")]
    [InlineData("Marina", "Hey, Hello Marina")]
    [InlineData("Luiz", "Hey, Hello Luiz")]
    [InlineData("Arthur", "Hey, Hello Arthur")]
    [InlineData("Livia", "Hey, Hello Livia")]
    public void TestHello(string entry, string expected)
    {
        var response = SayMeHello.Hello(entry);
        response.Should().Be(expected);
    }
}
```

Enviando alguns casos de entrada, armazenar o valor em uma variável e testar essa resposta. Porém, temos um problema, a função Hello() não retorna nada, ou seja não podemos armazenar esse valor em uma variável!

Essa frase é mandada para o console, então o que temos que fazer? Resposta: Nos testes, temos que “simular” um console, ou seja, vamos dizer para nossa aplicação onde ela deve imprimir aquela mensagem.

E fazemos isso no C# com um objeto chamado StringWriter do namespace System.IO


using Xunit;
using FluentAssertions;
using xpt;
using System;
using System.IO;
namespace xpt.test;
public class TestSayMeHello
{
    [Theory]
    [InlineData("Rahel", "Hey, Hello Rahel")]
    [InlineData("Marina", "Hey, Hello Marina")]
    [InlineData("Luiz", "Hey, Hello Luiz")]
    [InlineData("Arthur", "Hey, Hello Arthur")]
    [InlineData("Livia", "Hey, Hello Livia")]
    public void TestHello(string entry, string expected)
    {
        using(var stringWriter = new StringWriter())         //1
        {     
            Console.SetOut(stringWriter);                    //2
            SayMeHello.Hello(entry);                         //3
            var response = stringWriter.ToString().Trim();   //4
            response.Should().Be(expected);                  //5                                              
        }
    }
}

Vamos analisar:

No ponto 1, criamos uma variável do tipo StringWriter para usar;
No ponto 2, vamos dizer para o Console, que a saída padrão dele agora será nossa variável chamada stringWriter;
No ponto 3, chamamos a função que imprime no console, só que agora essa saída será registrada na variável stringWriter;
No ponto 4, armazenamos essa saída em uma variável, usamos o .ToString() para pegar essa string e a função .Trim( ) para remover os espaços finais;
No ponto 5, finalmente testamos corretamente a saída do nosso console.

Legal, e se forem várias linhas?

Por exemplo, podemos evoluir esse método para um diálogo:

namespace xpt;
public class SayMeHello
{
    public static void HelloHarder(string name)
    {
        Console.WriteLine($"Hey, Hello {name}");
        Console.WriteLine($"Can i call u {name}zito?");
        Console.WriteLine($"No?");
        Console.WriteLine($"Ok?");
    }
}

Como testamos várias linhas no console?

Resposta: Com o mesmo objeto, variando o tratamento:

using Xunit;
using FluentAssertions;
using xpt;
using System;
using System.IO;
namespace xpt.test;
public class TestSayMeHello
{
    [Theory]
    [InlineData("Rahel", "Hey, Hello Rahel", "Can i call u Rahelzito?")]
    [InlineData("Marina", "Hey, Hello Marina", "Can i call u Marinazito?")]
    [InlineData("Luiz", "Hey, Hello Luiz", "Can i call u Luizzito?")]
    [InlineData("Arthur", "Hey, Hello Arthur", "Can i call u Arthurzito?")]
    [InlineData("Livia", "Hey, Hello Livia", "Can i call u Liviazito?")]
    public void TestHelloHarder(string entry, string expected1call, string expected2call)
    {
        using(var stringWriter = new StringWriter()) 
        {     
            Console.SetOut(stringWriter);
            SayMeHello.HelloHarder(entry);
            var response = stringWriter.ToString().Trim().Split("\n");  // 1
            response[0].Should().Be(expected1call);                     // 2                              
            response[1].Should().Be(expected2call);                     // 3
        }
    }
}

Agora diferentemente, temos os pontos 1, 2 e 3 onde:

No ponto 1, dividimos a string separada por quebras de linha (\n);

No ponto 2, testamos a primeira linha;

No ponto 3, testamos a segunda linha. De forma similar poderíamos estender essa lógica para várias linhas.

Por fim, e se a função exigir entrada da pessoa usuária pelo Console?

Olhe agora um método que pede a entrada da pessoa usuária para executar sua funcionalidade:

namespace xpt;
public class SayMeHello
{
    public static void HelloSayYourName()
    {
        Console.Write("Hey, say me your name:");
        var userName = Console.ReadLine();
        Console.WriteLine($"Ok, Hello {userName}");
    }
}

E também temos no C# um objeto de StringReader onde podemos “simular” a entrada da pessoa usuária pelo console:

using Xunit;
using FluentAssertions;
using xpt;
using System;
using System.IO;
namespace xpt.test;
public class TestSayMeHello
{
    [Theory]
    [InlineData("Rahel", "Ok, Hello Rahel")]
    [InlineData("Marina", "Ok, Hello Marina")]
    [InlineData("Luiz", "Ok, Hello Luiz")]
    [InlineData("Arthur", "Ok, Hello Arthur")]
    [InlineData("Livia", "Ok, Hello Livia")]
    public void TestHelloSayYourName(string entry, string expected)
    {
        using(var stringWriter = new StringWriter()) //1
        {
            using(var stringReader = new StringReader(String.Join("\n", entry))) //1
            {      
                Console.SetOut(stringWriter); 
                Console.SetIn(stringReader);                                     //2
                SayMeHello.HelloSayYourName();                                   //3
                
                var response = stringWriter.ToString().Trim();                   //4
                response.Should().Contain(expected);                             //5                    
            }          
        }
    }
}

O que mudou agora? estamos utilizando dois objetos, um StringWriter para simular um console de saída e um StringReader para simular um console de entrada.

No ponto 1, criamos um objeto StringReader e passamos para ele a entrada que ele vai enviar quando for requisitado: new StringReader(String.Join("\n", entry)));

No ponto 2, definimos a variável stringReader como padrão para entrada da nossa aplicação;

No ponto 3, chamamos a função que irá requisitar uma entrada e, surpresa!, o StringReader já se encarrega de enviar a entrada para o console dessa aplicação;

No ponto 4, recebemos a resposta do console;

No ponto 5, testamos de outra forma, se a string completa contém a frase esperada.

Relembrando🧠
O que são estruturas de repetição?
São estruturas que permitem executar repetidamente um trecho de código.

O que são while, do/while, for e foreach?
São os tipos de estruturas de repetição, com diferentes sintaxes.

Como utilizar break?
É uma instrução utilizada para interromper a execução de uma laço de repetição.

Como utilizar continue?
É uma instrução utilizada para pular para o próximo laço de repetição.

Como testar as funções utilizando xUnit + FluentAssertions?
Utilizando as Bibliotecas .NET para trabalhar com testes.