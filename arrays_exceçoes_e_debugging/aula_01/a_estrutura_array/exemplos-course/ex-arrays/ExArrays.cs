// Como declarar Arrays em C#

// <Tipo>[] <NomeDoArray>; 
int[] criandoArray;

// Agora, para colocarmos valores existem algumas sintaxes diferentes:

//Criando o array
int[] instanciandoArray;

//instanciando array: 
//array = new tipo[tamanhoDoArray];
instanciandoArray = new int[10];

// É comum simplificarmos a inicialização acima e fazer junto da criação do Array:

int[] criandoEInstanciando = new int[] { 1, 2, 3, 4, 5 };

// Podemos também inicializar um Array com valores pré-definidos de duas formas diferentes:

int[] formaUm = new int[] { 1, 2, 3, 4, 5 };

int[] formaDois = { 1, 2, 3, 4, 5 };

// Array de string: 

string[] myFirsStringArray1 = new string[] {"Vamo", "que", "vamo", "!"};

string[] myFirsStringArray2 = {"Vamo", "que", "vamo", "!"};

int[] myArray = new int[4] {6, 9, 5, 8};

Console.WriteLine(myArray[4]);
// Saída: Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

Console.WriteLine("Chegou Aqui!");
// Essa linha não será executada

