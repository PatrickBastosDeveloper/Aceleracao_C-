<h1>Conhecendo os tipos de C#</h1>

* Dados são diferentes tipos de valores que possuem a finalidade de qualificar ou quantificar algo.

Estes mesmos dados quando processados geram informação, a qual, quando formatada, causa relevância a algo ou alguém.

<h2>Compreendendo o que são Variáveis</h2>

Vamos imaginar uma variável como uma “caixinha etiquetada” de tamanho limitado. Podemos guardar nela somente um determinado tipo de conteúdo por vez, enquanto os outros valores são guardados durante o tempo de execução. Neste sentido, vamos variar de valor, mas jamais variar o tipo do conteúdo.

🖊: Ao criarmos uma variável, um espaço específico na memória RAM é reservado para manipulações de dados. Toda variável deve possuir um nome como uma “etiqueta” , pois é por meio desse nome que ocorre a manipulação de dados.

Tipos primitivos e seus respectivos valores possíveis:
```
Tipo	Valores Possíveis
bool	true e false
byte	0 a 255
sbyte	-128 a 127
short	-32.768 a 32.767
ushort	0 a 65.535
int	-2.147.483.648 a 2.147.483.647
uint	0 a 4.294.967.295
long	-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
ulong	0 a 0 a 18.446.744.073.709.551.615
float	Valores de ponto flutuante de até 7 dígitos. Ex: -3.402823e38 a 3.402823e38
double	Valores de ponto flutuante de até 15 dígitos. Ex: -1.79769313486232e308 a 1.79769313486232e308
decimal	Números com até 28 casas decimais. Ex: 0.991m, 33.333m
char	Um unico caractere delimitado por aspas simples. Ex: ‘ç’,’M’,’f’
```
<h2>
Tipos de Linguagens
</h2>

O C# é uma linguagem de programação considerada fortemente tipada, pois toda e qualquer variável necessariamente deve explicitar o tipo de dado que armazena no ato de sua criação, dando assim um nome a ela. Esse processo de nomeação é conhecido como declaração de variável.

exemplo de uma declaração fortemente tipada:

```
int x;
decimal y;
bool z;
```

Ao tentar associar um valor de algum tipo a uma variável de outro tipo causará um erro. Assim como ocorreu no exemplo abaixo:

```
decimal Name = "Maria"; //ok
int Age = 29.5; //ok
string Ammount = 10; //erro!
```
Outros erros comuns que podem ocorrer:

- Erro léxico: quando é adicionado algum caractere especial não apropriado. Ex: uma letra no meio de um número inteiro 12a3.

```
// Exemplos de erros lexicos
int number = 12a3;
decimal !average = 7.7;
string n@ame = "Trybe";
```
- Erro de sintaxe: quando instruções do programa estão mal formulados. Ex: parênteses que não se fecham, instrução sem o caractere que simboliza o término ;.

```
// Exemplos de erros de Sintaxe
decimal percent = (10*100/100;
int position = 10
```

- Erro semântico: quando ocorre um erro no significado do código mesmo estando tudo sintaticamente correto. Ex: Divisão por zero, acessar uma posição de um Array que não existe, utilizar uma variável não declarada.

```
// Exemplos de erros Semânticos
int[] array = new int[10];
array[10] = 100;
```

- Erro de Lógica: São mais complexos de identificar, pois não possuem erros léxicos, sintáticos ou semânticos, entretanto, a execução do código não ocorre como esperado. Ex: troca indevida de um operador lógico, acessar a primeira posição de um array utilizando o número do índice 1, sendo que um array começa da posição 0.

<h2>Utilizando variáveis no C#</h2>

**conteúdo no arquivo Program.cs/Exemplo1 e Exemplos

<h2>Nomenclatura de variáveis</h2>

Escrever bons nomes às variáveis que compõem o programa em desenvolvimento, contribui para a compreensão do que esta sendo manipulado, ou o tipo de informação que aquela variável armazena naquele momento, além de indicar qual é a sua finalidade.

Existem algumas regras básicas para criação de nomes de variáveis que devemos adotar:

1. Nomes de variáveis devem ser compostos apenas por letras, números e sublinhado.
2. Sempre começar por uma letra e não colocar acentuações.
3. Não pode ser igual a nenhuma palavra reservada da linguagem.

Para exemplificar, observe no trecho de código abaixo o que não fazer:
```
int o;
```
Agora acompanhe a seguinte evolução:
```
int oct;
```
Vamos deixar essas variáveis ainda mais descritivas:
```
int octber;
```
Podemos evoluir ainda mais a escrita desse código:
```
int numberOfOrdersInOctber;
```
Bons nomes de varáveis geralmente serão compostos por mais de uma palavra como neste exemplo:

```
bool orderStatusDelivered;
```

Mais alguns exemplos: 
```
//Declarando uma variável do tipo string ideal para dados literários e frases 
string excerptFromBook = "Ser ou não ser, eis a questão";

//Declarando uma variável float que pode armazenar um valor de ponto flutuante com precisão de até 7 digitos
// O sufixo f informa o compilador que o valor é float
float floatValue = 100.0f;

//Declarando uma variável double que pode armazenar um valor de ponto flutuante com precisão de até 15 digitos
// O sufixo d informa o compilador que o valor é um double
double doubleValue = 100.0d;

//Declarando uma variável decimal que pode armazenar um valor de ponto flutuante com precisão de até 29 digitos.
// O sufixo M informa o compilador que o valor é um decimal
decimal decimalValue = 100.0M;

//Declarando uma variável char que pode armazenar um unico caractere.
char letter = 'T'; 
```
Para demonstrar a utilização de varáveis, vamos utilizar como exemplo a estrutura básica de algoritmos sequenciais que possuem os seguintes elementos:

* Entrada de Dados: nesta etapa declaram-se as variáveis que serão necessárias para a resolução do algoritmo e também é dado a entrada dos respectivos dados que serão posteriormente processados. Esta entrada pode ter diversos tipos de origem, uma interface gráfica, um sensor ou simplesmente dados digitados do teclado.

*Processamento: Aqui, podem ocorrer uma série de procedimentos, dentre os mais comuns são os envolvendo cálculos, persistência de dados e validações.

*
Saída de Dados: Por fim, nesta etapa os dados processados sofrem algum tipo de formatação e são exibidos de alguma forma.

<h2>Interfaces de comunicação com o programa</h2>

Pessoas desenvolvedoras são contratadas para desenvolver aplicações que serão utilizadas por outras pessoas, e estas aplicações devem fornecer algum tipo de interface de comunicação capaz de trocar informações com quem esta utilizando.

Estas interfaces podem ser ricas contando com vários recursos visuais ou simplistas utilizando somente recursos textuais para interação com a pessoa que utiliza a aplicação.

**Console Application** é uma categoria de aplicação cuja interface de comunicação é puramente textual, pois não possui uma interface gráfica **GUI (Graphical User Interface)** de comunicação com a pessoa usuária.

GUI é o que possibilita alguns eventos interativos como clicks, rolagem de scroll do mouse, passar o ponteiro do mouse por cima, segurar e arrastar, dentre outros. O que NÃO é possível em uma Console Application.

**Entrada de Dados:** O método **Console.ReadLine()** lê a próxima linha de caracteres do fluxo de entrada até ser pressionado a tecla Enter. Como o retorno deste método é um dado do tipo string, é necessário fazer conversões quando queremos trabalhar com outros tipos de dados.

Veja no exemplo a seguir onde temos variáveis sendo atribuídas utilizando este método. Note que somente para a variável do tipo string não há necessidade de conversão de dados.
```
//Entrada de Dados
int Age = int.Parse(Console.ReadLine());
decimal Average = decimal.Parse(Console.ReadLine());
bool Permission = bool.Parse(Console.ReadLine());
string Name = Console.ReadLine();
```

**Saída de Dados:** O método Console.WriteLine() é responsável por lançar informaçoes no Console como podemos ver no trecho de código e imagem a seguir.

```
//Saída de Dados
Console.WriteLine("Este é um exemplo de saída de dados");
```

**Concatenação de Dados**: Uma das manipulações mais relevantes quando se desenvolve algum tipo de saída de dados é a capacidade de concatenar dados em uma string, ou seja, unir dados em uma única string com a intenção de exibir e complementar alguma informação com o valor de alguma variável.
Na linguagem C# o operador responsável por realizar a concatenação é o sinal +.

```
//Exemplo de concatenação de Dados
int Number = 10;
string Name = "Trybe";
Console.WriteLine("O valor da variável numero é: "+Number);
Console.WriteLine("Eu sou um estudante " + Name +"!");
```
A partir de agora, podemos compreender a resolução de alguns algoritmos que manipulam diferentes tipos variáveis seguindo o fluxo genérico de entrada, processamento e saída.

Exemplo:

Escreva um algoritmo para calcular e exibir o número de lâmpadas necessárias para iluminar determinado cômodo de uma residência.
Entrada de dados: a potência da lâmpada utilizada (em watts) e as dimensões (largura e comprimento, em metros) do cômodo.

Considere que a potência necessária é de 18 watts por metro quadrado.

Processamento: após o algoritmo obter os dados de entrada ele segue a seguinte sequencia:

Calcula quantos metros quadrados possui o cômodo multiplicando width por length.

Calcula o quociente X dividindo a potência da lâmpada que será utilizada por 18, quantidade necessária para iluminar 1 metro quadrado.

Calcula a quantidade de lâmpadas necessárias dividindo o total de metros quadrados do cômodo pelo quociente X.

Saída de Dados: Uma mensagem coerente e bem formatada deve ser exibida na tela do Console para a pessoa que utiliza o programa e forneceu os dados de entrada.

**conteúdo no arquivo Program.cs/Exemplo2

<h2>Outros Tipos de Dados do C#</h2>

O C# também possui outros tipos de dados e estruturas para complementar a manipulação de dados como o struct e enum.

**Enum**

As enumerações ou enum, como é chamado na linguagem C#, é um tipo de dado constante, fortemente tipado e estático, ou seja, não há necessidade de instanciar um objeto utilizando a palavra reservada **new**, seu acesso é feito a partir da estrutura em que o enum estiver contido. As enumerações possuem valores limitados a um conjunto de nomes simbólicos chamados elementos ou membros e não podem ser declaradas em métodos.

Este tipo de dado é útil quando há necessidade de representar algum conjunto de dados que não sofrerá tantas alterações no decorrer do desenvolvimento de um projeto, veja a seguir como declarar e utilizar um enum.

```
//Criando um enum
enum CardinalPoints
{
    Norte,
    Sul,
    Leste,
    Oeste
};
//Utilizando um enum
CardinalPoints direction = CardinalPoints.Norte;
Console.WriteLine("Ponto Cardeal: "+direction);
```
```
saída: 
//Ponto Cardeal: Norte
```
<h2>Struct</h2>

O struct é uma alternativa mais leve do C# ao usar Class, por ser armazenado no stack da memória. Embora se pareça com a estrutura Class possui diferenças bem relevantes:

Não é possível herdar uma struct.
Não se pode ter construtores vazios.
Veja um exemplo abaixo de criação e utilização de uma struct.

```
//Criando uma struct
struct Schedule
{
    public int hour, minute, second;
    public string shift;
}

//utilizando uma struct
Schedule now;
now.hour = 10;
now.minute = 30;
now.shift = "AM";
Console.WriteLine("Horário: " + now.hour + ":" + now.minute + " " + now.shift);
```

Em uma struct é permitido que se utilize construtor e métodos para se ter mais controle dos valores manipulados, veja na alteração a seguir:
```
//Criando uma struct
struct Schedule
{
    private int hour, minute, second;
    private string shift;

    //Construtor da struct
    public Schedule(int hour, int minute, int second, string shif) 
    { 
        this.hour = hour % 24;
        this.minute = minute % 60;
        this.second = second % 60;
        this.shift = shif;
    }

    // metodo da struct
    public string getSchedule() 
    { 
        return hour.ToString()+ ":" + minute.ToString() + ":" + second.ToString()+" "+shift;
    }
}

//Incializando uma struct com construtor
Schedule now = new Schedule(10,30,0,"AM");
Console.WriteLine("Horario: "+ now.getSchedule());
```

Note que para esta nova implementação foi utilizado o comando new que aciona o construtor da struct , esse por sua vez recebe os valores via passagem de parâmetros e atribui as propriedades internas da struct.

Outra possibilidade permitida ao se utilizar struct é a capacidade de atribuir uma struct completa já inicializada para outra, veja a seguir:
```
//Criando uma struct

//Incializando uma struct com construtor
Schedule now = new Schedule(10,30,0,"AM");
Console.WriteLine("Horario: "+now.getSchedule());

//atribuindo uma struct iniciada para uma nova struct
Schedule now2 = now;
Console.WriteLine("Horario2: "+now2.getSchedule());

struct Schedule
{
    private int hour, minute, second;
    private string shift;

    //Construtor da struct
    public Schedule(int hour, int minute, int second, string shif) 
    { 
        this.hour = hour % 24;
        this.minute = minute % 60;
        this.second = second % 60;
        this.shift = shif;
    }
    // metodo da struct
    public string getSchedule() 
    { 
        return hour.ToString()+ ":" + minute.ToString() + ":" + second.ToString()+" "+shift;
    }
}

```

<h2>Outros tipos de dados que representam números inteiros</h2>

Dependendo de alguns requisitos principalmente relacionados ao uso de memória, podemos escolher outros tipos numericos no C#.

Para termos um controle mais preciso, podemos utilizar tipos signed que permitem o armazenamento de valores negativos e os unsigned cujo os valores podem ser somente o 0 e valores positivos.

Veja a seguir uma tabela com todos os tipos signed e unsigned do C#.

Tipo	 | Tamanho	         |     Valor mínimo	    | Valor máximo
-------|-------------------|----------------------|---------
sbyte	 | 8-bit(signed)	   |    -128	            |127
byte	 | 8-bit (unsigned)	 |    0                 |	255
short	 | 16-bit (signed)   |	-32768              |	32767
ushort |16-bit (unsigned)  |	0	                  | 65535
int	   |  32-bit (signed)	 | -2147483648	        | 2147483647
uint	 |  32-bit (unsigned)|	0	                  | 4294967295
long	 |  64-bit (signed)	 | -9223372036854775808	| 9223372036854775807
ulong	 |  64-bit (unsigned)| 0	                  | 18446744073709551615

<h2>Constantes</h2>

Com um nome bem sugestivo, uma constante é um valor que não pode ser alterado ao decorrer do tempo de execução fazendo o oposto a uma variável.

No C#, utilizamos a palavra reservada const para declarar uma constante antes do seu tipo. O processo de declarar, acessar e utilizar a constante é semelhante ao de se trabalhar com variáveis, entretanto, ao se declarar e definir o valor de uma constante não é possível alterar seu valor em nenhuma outra linha.

```
//Como declarar uma constante
const string url = "https://www.betrybe.com/";
const int numberOfAttemptsAllowed = 5;
```

<h2>Variáveis com tipo implícito</h2>

O C# traz a possibilidade de implicitamente definir um tipo de dado para uma variável quando se declara utilizando a palavra reservada var. Com essa instrução, o compilador vai deduzir o tipo a partir da expressão ou dado que está sendo atribuído a ela, podendo assim ser qualquer tipo primitivo ou definidos pela pessoa que desenvolve o programa. 

```
  //esta variável será compilada como string
var school = "Trybe";

//esta variável será compilada como int
var semester = 1;

//esta variável será compilada como um tipo anônimo
var student = new { name = "Jorge", age = 30 };

Console.WriteLine("Olá! Me chamo " + student.name + " " +
                  "sou um estudante da escola " + school + " " +
                  "estou no " + semester + "º semestre " +
                  "e tenho " + student.age + " anos"); 
```

⚠️ Aviso: Ao implicitamente definir um tipo de dado com uso do var, não é possível trocar este tipo. Caso aconteça, o compilador irá acusar um erro.

Outro benefício de se utilizar a declaração implícita é quando existe uma Classe com o nome muito extenso podendo ser substituída ao definir o tipo da variável por var, veja neste exemplo:

```
ClassWithAnExtremelyLongName obj1 = new ClassWithAnExtremelyLongName();

//codigo mais curto e mais legível
var obj2 = new ClassWithAnExtremelyLongName();
```

Além disso, existem algumas regras que devem ser adotadas para o uso de variáveis implícitas:

1. Uma variável com tipo implícito só pode ser utilizada e inicializada no mesmo trecho em que ela existe.
2. Não se pode declarar uma variável implícita como null.
3. Variáveis implícitas não podem ser atributos de Classes.
4. Não se pode inicializar múltiplas variáveis implícitas numa mesma instrução.

<h2>Operações Aritméticas</h2>

Para processamentos que envolvam cálculos matemáticos é importante conhecermos os operadores aritméticos e como trabalhar com eles.

Operador | Descrição                 |
---------|---------------------------|
(+)	       | Adição                    |
(-)	       | Subtração                 |
(*)	       | Multiplicação             |
(/)	       | Divisão                   |
(%)	       | Módulo (resto da divisão) |

Utilizando estes operadores entre variáveis.

```
//Adição
int a = 50, b = 50;
int result1 = a + b;
Console.WriteLine(a + " + " + b + " = " + result1);

//Subtração
int c = 77, d = 21;
int result2 = c - d;
Console.WriteLine(c + " - " + d + " = " + result2);

//Multiplicação
int e = 5, f = 5;
int result3 = e * f;
Console.WriteLine(e + " * " + f + " = " + result3);

//divisão
int g = 90, h = 9;
int result4 = g / h;
Console.WriteLine(g + " / " + h + " = " + result4);

//módulo
int i = 36, j = 7;
int result5 = i % j;
Console.WriteLine("O resto da divisão de "+i+" por "+j+" é "+result5);
```
<h2>Ordem das expressões</h2>

A linguagem C# obedece às mesmas regras utilizadas na matemática em que um conjunto de operações de multiplicação e divisão serão realizadas antes das operações de soma e subtração. A ordem pode ser controlada com uso de parênteses executando primeiramente o que esta nos mais internos até os mais externos, veja no trecho a seguir:
```
//ordem de execução
int a = 5, b = 10, c = 15;
int result1 = (a + b * c);
Console.WriteLine("("+a+" + "+b+" * "+c+") = "+result1);

//utilizando parênteses
int result2 = ((a + b) * c);
Console.WriteLine("((" + a + " + " + b + ") * " + c + ") = " + result2);
```

<h2>Operadores Aritméticos de Atribuição reduzida</h2>

É adotado como uma boa prática utilizar atribuições reduzidas evitando assim a repetição do nome da variável manipulada. Com isto, podemos incrementar ou decrementar de forma mais rápida e com menos código.

Operador Aritmético| Descrição
---------|------------
(++)	| Incrementa + 1
(--)	| Decrementa - 1
(+=)	| Incrementa
(-=)	| Decrementa
(*=)	| Incrementa multiplicando
(/=)	| Decrementa dividindo
(%=)	| Incrementa modulando (resto da divisão)

Demonstração de como utilizar estes operadores de atribuição reduzida:

```
int a = 1;
//incrementa + 1 ao valor de a
a++; //substitui a instrução a = a + 1 
Console.WriteLine("A = "+a);

int b = 10;
//decrementa o -1 ao valor b
b--; //substitui a instrução b = b - 1
Console.WriteLine("B = " + b);

//incrementa qualquer valor à direita na variável à esquerda
int c = 23;
c += 15; //substitui a instrução c = c + 15 
Console.WriteLine("C = " + c);

//decrementa qualquer valor à direita na variável à esquerda
int d = 100;
d -= 25; //substitui a instrução d = d - 25 
Console.WriteLine("D = " + d);

//incrementa multiplicando qualquer valor à direita na variável à esquerda
int e = 11;
e *= 3; //substitui a instrução e = e * 3 
Console.WriteLine("E = " + e);

//decrementa dividindo qualquer valor à direita na variável à esquerda
decimal f = 11;
f /= 3; //substitui a instrução f = f / 3 
Console.WriteLine("F = " + f.ToString("N2"));

//decrementa com a operação de módulo de qualquer valor à direita na variável à esquerda
decimal g = 11;
g %= 3; //substitui a instrução g = g % 3 
Console.WriteLine("G = " + g.ToString("N2"));x
```