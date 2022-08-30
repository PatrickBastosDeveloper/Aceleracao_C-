<h1>Conhecendo as estruturas de controle do .NET</h1>

Você já se perguntou o que classifica uma linguagem de programação como eficiente e útil? Essa classificação pode ser derivada da capacidade que determinada linguagem tem de alterar a ordem de execução dos blocos de instrução.

Nesta lição, vamos aprender sobre duas instruções bem famosas no mundo da programação: if e switch/case.

Isso ocorre devido ao uso de estruturas de controle, definidas como ordem de execução dos blocos de instruções. O comportamento do sistema é reflexo do caminho percorrido pelo fluxo de execução das instruções, e a sequência desse fluxo pode ser alterada pelas estruturas de controle.

<h2>A ordem das instruções altera o resultado</h2>

Um programa é composto por diversas instruções, desde a declaração das variáveis até a execução de estruturas mais complexas. A ordem na qual as instruções são executadas por um programa é chamada de fluxo de controle ou fluxo de execução. Programas que possuem maior facilidade de execução podem ser escritos com apenas um fluxo unidirecional. No entanto, a complexidade do algoritmo para englobar todos os cenários possíveis cria a necessidade de gerenciamento do fluxo de controle com loops e instruções de controle. O fluxo de controle pode variar sempre que um programa é executado, vai depender de como o programa reage às entradas que recebe em tempo de execução.

```
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe o raio de um círculo (deve ser um número inteiro)");
        string? response = Console.ReadLine();
        int radius = 0;
        var canConvert = Int32.TryParse(response, out radius);

        if(canConvert)
        {
            const double pi = 3.14159;

            double circumference = pi * (2 * radius);

            Console.WriteLine("A circunferência de um circulo com raio "+ radius + " é igual a " + circumference);
        }
        else
        {
            Console.WriteLine("O texto digitado não é um número inteiro.");
        }
    }            
}
```

No código acima, o programa define se calcula e imprime a circunferência de acordo com o valor da variável canConvert. Assim, conseguimos alterar a ordem na qual as instruções são executadas de acordo com o valor informado pela pessoa usuária.

<h2>A estrutura de seleção if</h2>

A instrução if é utilizada para executar blocos de instruções condicionalmente por meio de uma expressão booleana (uma condição com resultado verdadeiro ou falso).

```
if (condição)
{
    //bloco de código a ser executado quando a condição for VERDADEIRA    
    comandos;
}
```

A palavra if em português significa se. Considerando isso, vamos observar como fica a leitura do código:

“Se a condição for verdadeira, então devo executar os comandos.”


```
if(age > 15)
{        
    Console.WriteLine("idade maior que quinze");
}
```

Note que, no código acima, se a variável ‘age’ estiver com um valor maior que 15 (age > 15), o sistema executará o código que está entre as chaves - nesse caso, a impressão no console da frase: "idade maior que quinze"

<h2>Utilizando a estrutura if/else</h2>

Nem todo if precisa de um else, mas todo else precisa de um if.

Talvez você possa estar se perguntando: “Mas por quê?”

Resposta: A cláusula else é opcional na instrução if e seu conteúdo será executado somente se o resultado da condição avaliada no if for uma expressão booleana falsa. Assim, a existência de um bloco else está condicionada à existência de uma instrução if.

```
if(month == 1)
{        
    Console.WriteLine("mês janeiro");
}
else
{
    Console.WriteLine("mês diferente de janeiro");
}

```

No exemplo acima, o bloco else será executado quando a variável month tiver um valor diferente de 1.

<h2>Efeito cascata</h2>

Muitas vezes seu sistema vai precisar tomar ações diferentes, considerando várias condições. 

Exemplo:

```
if(number > 0)
{
     Console.WriteLine("maior que zero");
}
else 
{
    if(number < 0)
    {
        Console.WriteLine("menor que zero");
    }
    else
    {
        Console.WriteLine("igual a zero");
    }
}
``

No exemplo acima, o programa verifica se a variável number é maior que zero. Caso não seja, temos a linha do else if, que verifica se number é menor que zero. Por último, caso a variável number não atenda a nenhuma das condições anteriores, fará o que está no bloco else, ou seja, Console.WriteLine(“igual a zero”)

<h2>Instruções de uma única linha</h2>

Na linguagem C#, um bloco de instrução é sempre colocado entre chaves {}, de modo a delimitar seu contexto. Porém o uso das chaves não é obrigatório para definir uma instrução de uma linha do if/else. Observe o exemplo abaixo:

``
if(number > 10)
    Console.WriteLine("maior que 10");
else
    Console.WriteLine("menor ou igual a 10");
    
```

Note que utilizamos uma instrução de única linha sem o uso entre chaves {}

De olho na dica👀: Podemos também reduzir a quebra de linha!

```
if(number > 10) Console.WriteLine("maior que 10");
else Console.WriteLine("menor ou igual a 10");
```

<h2>Estrutura de seleção múltipla switch/case</h2>

```
switch (number)
{                
    case > 0:
        Console.WriteLine("maior que 0");
        break;               
    case 0:
        Console.WriteLine("igual a zero");
        break;
    default:                    
        Console.WriteLine("menor que zero");
        break;
}

```

Acima foi declarado para a estrutura switch que será analisado o valor da variável number. A instrução case diz os possíveis casos para os valores de number, ou seja, case > 0, o quer dizer que se number for maior que 0, será executado o bloco de código.

Além disso, temos mais um caso de verificação da variável number: case 0 se number igual a 0 será executado o bloco de código, e se nenhum dos case for verdadeiro, o sistema fará a execução do bloco de código default.

Anota aí 🖊:

* case é finalizado por dois pontos(:) e não ponto e vírgula(;) como a maioria das instruções;
* break define o final do bloco da execução do switch;
* default será executado se nenhum case for satisfeito.

<h2>Operadores de comparação no C#</h2>

Permitem avaliar os valores de uma expressão e retornar um valor booleano, ou seja, verdadeiro ou falso.

Operador	Descrição	Sintaxe	Resultado = Verdade
>	Maior	a > b	Se a for maior que b
>=	Maior ou igual	a >= b	Se a for maior ou igual a b
<	Menor	a < b	Se a for menor que b
<=	Menor ou igual	a <= b	Se a for menor ou igual a b
==	Igual	a == b	Se a for igual a b
!=	Diferente	a != b	Se a for diferente de b

<h2>Operadores lógicos do C#</h2>

Operadores lógicos servem para avaliar duas expressões booleanas e retornam um valor booleano (verdadeiro ou falso).

Nos exemplos abaixo, a > b e b < 4 retornam valores verdadeiro ou falso. Os operadores lógicos comparam os retornos das expressões comparadas para gerar o resultado da expressão.


Operador	Descrição	Exemplo	Resultado
&&	AND/E	a > b && b < 4	Verdade se todas as expressões lógicas forem avaliadas como verdadeiras
||	OR/Ou	a > b || b < 4	Verdade se pelo menos uma expressão lógica for avaliada como verdadeira
!	NOT/Não	!(a > b)	É uma expressão de negação, sendo assim, inverterá o valor da expressão

---

Para não esquecer mais 🧠

* Estruturas de controle

Permitem alterar a ordem de execução dos blocos de instruções.

* Fluxo de controle

Ordem em que os blocos de instruções são executados.

* Como utilizar if, if/else e if/else aninhados

Estrutura de controle que executa bloco de instruções conforme a avaliação de uma instrução.

* Como utilizar switch/case

Estrutura de controle que permite avaliar valores para determinada variável.

* Quais são os operadores de comparação de C#

, >=, <, <=, == e !=

* Quais são os operadores lógicos de C#

&&, || e !

* Como testar as funções utilizando xUnit + FluentAssertions

Bibliotecas .NET para trabalhar com testes.

