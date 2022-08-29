<h2>Transformação entre tipos</h2>

C# é uma linguagem tipada em tempo de compilação, ou seja, as variáveis possuem tipos específicos logo no momento em que o código é compilado, possuindo assim suas próprias propriedades estáticas.

Entretanto, muitas vezes, em um algoritmo precisamos realizar operações entre variáveis de tipos diferentes. Por exemplo:

Comparar variáveis de tipos diferentes
```
3 (int) >= 2.5 (float) ?
```
Realizar operações matemáticas entre variáveis
```
5.3 (float) - 10.333333333 (decimal)
```
Essas operações podem até gerar, como produto, uma variável de tipo diferente. Para resolver essa situação, vamos ver o que é Casting, conhecida em C# por transformação.

A transformação de uma variável de determinado tipo em outro pode ocorrer de diferentes formas. Essas transformações são chamadas de:

Cast Implícito: ocorrem de maneira mais automática, sem que a pessoa desenvolvedora precise intervir via código.

Cast Explícito: quando precisamos escrever a transformação e como ela irá ocorrer via código.

Essas diferentes formas de se realizar o casting trazem prós e contras que você, como pessoa desenvolvedora, precisa ter atenção. Desse modo, poderá realizar a melhor escolha, de acordo com cada situação.

<h2>Cast Implícito</h2>

O casting implícito, como o próprio nome sugere, ocorre quando não declaramos no código que essa transformação deve ocorrer, ou seja, a deixamos implícita no código.

Se as variáveis forem de tipos compatíveis entre si, a transformação é feita automaticamente pelo compilador da linguagem, assim como ocorre no exemplo abaixo:
ex1 no Program.cs
```
public class Program
{
    public static void Main()
    {        
        int someIntNumber = 51;
        long longlNumberCast = someIntNumber;

        Console.WriteLine(longlNumberCast);
    }            
}
```

No exemplo acima, podemos observar uma conversão implícita acontecendo, onde a variável do tipo long consegue, perfeitamente e sem perda de informação, acomodar o valor da variável do tipo int.

Isso ocorre porque uma variável do tipo long é compatível com uma variável do tipo int, pois int representa um número inteiro em que cabem 32 bits. Já o tipo long representa um número inteiro em que cabem 64 bits. Com isso, é possível converter facilmente um tipo int em um tipo long sem perda de informação pois ainda sobrariam 32 bits na var long.

Note que essa conversão ocorreu sem a necessidade de uma sintaxe adicional, ou seja, não precisamos fazer nada para que a transformação ocorresse, caracterizando assim uma transformação implícita.

Ok, mas qual é o uso interessante que poderíamos ter com esse tipo de conversão? 🤔
ex2 no Program.cs
```
public class Program
{
    public static void Main()
    {        
        int intResult = 5/2;

        Console.WriteLine(intResult);
    }            
}
```
Nessa situação, realizamos uma operação matemática de divisão, onde desejávamos obter um número inteiro como resultado. O valor esperado para essa divisão, caso considerássemos o valor exato, deveria ser algo em torno de 2,5. Entretanto, o compilador, de forma automática, ignora as casas decimais a fim de alocar esse resultado na nossa variável do tipo int. Assim, armazenando apenas o número 2 e descartando 0,5.

⚠️ Aviso: Vale ressaltar que, neste caso, ocorreu uma perda de informação, pois o valor não foi arredondado como o esperado; portanto, para esse tipo de utilização, se faz necessário entender se esse realmente era o comportamento esperado. Outro perigo para se considerar é que, em algumas situações, o uso excessivo de conversões implícitas pode acabar não deixando muito nítido o que está acontecendo no código e dificultar a legibilidade dele.

<h2>Cast Explícito</h2>

Nem sempre podemos deixar todo o trabalho pesado para o nosso compilador… Às vezes precisamos colocar a mão na massa.

Existem operações que NÃO podem ser feitas implicitamente, pois nós precisamos indicar a ação a ser tomada. Veja o exemplo abaixo:
ex3 no Program.cs
```
public class Program
{
    public static void Main()
    {        
        long someLongNumber = 516144066604654;
        int intNumber = someLongNumber;

        Console.WriteLine(intNumber);
    }            
}
```

No exemplo acima, ao contrário do que ocorreu na transformação de int para long, tentar atribuir o valor de uma variável do tipo long a uma do tipo inteiro não pode ocorrer naturalmente, pois os espaços de memória, agora, não são compatíveis.

Com isso, é gerado o seguinte erro ao tentar executar nosso código com dotnet test:

```
error CS0266: Não é possível converter implicitamente tipo "long" em "int". Existe uma conversão explícita (há uma conversão ausente?)

Ocorreu uma falha no build. Corrija os erros de build e execute novamente.
```

Nesse caso, devemos realizar a conversão explícita no código e, nesse cenário, temos várias formas de fazê-lo.

* O mais simples é adicionar a sintaxe (int) para indicar que queremos transformar, mesmo que ocorra perda de informação!
ex4 no Program.cs
```
public class Program
{
    public static void Main()
    {        
        long someLongNumber = 516144564564654;
        int intNumber = (int) someLongNumber;

        Console.WriteLine(intNumber);
    }            
}
```

Cuidado ao usar apenas o cast (int), pois se você perder informação no processo o C# não irá te avisar disso!

* Outra opção é utilizar o Convert acompanhada do .ToInt32, indicando assim que desejamos realizar uma conversão explícita e, com o .ToInt32, indicamos o tipo para o qual desejamos que a variável seja convertida.

```ex5 no Program.cs
public class Program
{
    public static void Main()
    {        
        long someLongNumber = 516144564564654;
        int intNumber = Convert.ToInt32(someLongNumber);

        Console.WriteLine(intNumber);
    }            
}
```

Nesse caso, o Convert.ToInt32 vai nos avisar de que o número 516144564564654 não cabe em uma variável int, com o seguinte erro:

```
Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32.
   at System.Convert.ThrowInt32OverflowException()
   at System.Convert.ToInt32(Int64 value)
   at Program.Main() in /Users/rahelund/C#/teste cod/Program.cs:line 6
```

Porém, se for possível converter o número, ele vai funcionar sem problemas:
ex6 no Program.cs
```
public class Program
{
    public static void Main()
    {        
        long someLongNumber = 42;
        int intNumber = Convert.ToInt32(someLongNumber);

        Console.WriteLine(intNumber);
    }            
}
```
```
// Resultado 42
```
<h2>Mais Usos para a Conversão Explícita</h2>

Podemos converter uma string para um número inteiro, por exemplo. Essa conversão é bem útil e comum em situações reais.
ex7 no Program.cs
```
public class Program
{
    public static void Main()
    {        
        string someString = "42";
        int convertInt = Convert.ToInt32(someString);

        Console.WriteLine(convertInt);
    }            
}
```

```
// 42
```

Mas como saberemos se ele realmente converteu a string em um int? 🧐

Resposta: Utilizando o operador is, que em Inglês significa “é”. Esse operador é utilizado para realizar comparações entre variáveis e tipos. Observe o exemplo a seguir:
ex8 no Program.cs
```
public class Program
{
    public static void Main()
    {        
        string someString = "2022";
        Console.WriteLine(someString is string);

        int convertInt = Convert.ToInt32(someString);
        Console.WriteLine(convertInt is int);
    }            
}
```
```
True
True
```

Com isso, podemos verificar o tipo de uma variável e, então, tomar decisões sobre como lidar com ela. Observe:
ex9 no Program.cs
```
public class Program
{
    public static void Main()
    {        
        string someString = "20";
        int number = 0;
        
        if(someString is string)
        {
            number = Convert.ToInt32(someString);
            Console.WriteLine(number);
        }
}
```
O código acima verifica se a variável someString é do tipo string e, caso seja verdadeiro, executa um cast para o tipo inteiro.

Esse tipo de estrutura de código é, normalmente, utilizado para tratar possíveis pequenos problemas no nosso código, que poderiam ser gerados por variáveis de tipos indesejados. Desta forma, podemos prevenir essas variáveis indesejadas e realizar uma conversão de antemão.

<h2>Testes</h2>

