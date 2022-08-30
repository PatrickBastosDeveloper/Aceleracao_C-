///////////////////////////Exemplo1/////////////////////////////////

// // Declaração de multiplas variaveis
// int x = 10, y = 25;

// // Saída de dados
// Console.WriteLine("O valor da variável x é " + x + " e o valor de Y é " + y);
// // Operação de soma
// Console.WriteLine(x+" + "+y+" = "+(x+y));
// // Operação de subtração
// Console.WriteLine(x+" - "+y+" = "+(x-y));
// // Operação de multiplicação
// Console.WriteLine(x+" * "+y+" = "+(x*y));
// // Operação de divisão
// Console.WriteLine(x+" / "+y+" = "+(x/y));

///////////////////////////Exemplo2/////////////////////////////////

//ENTRADA DE DADOS
// Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada'!");
// Console.WriteLine("Informe o nome do còmodo: ");
// string convenient = Console.ReadLine();

// Console.WriteLine("Informe em metros a largura deste cômodo: ");
// decimal width = decimal.Parse(Console.ReadLine());

// Console.WriteLine("Informe em metros o comprimento deste cômodo: ");
// decimal length = decimal.Parse(Console.ReadLine());

// Console.WriteLine("Informe a potência em watts da lâmpada que será utilizada: ");
// int power = int.Parse(Console.ReadLine());

// //PROCESSAMENTO
// decimal squareMeter = width * length;
// decimal quotientX = power / 18M;
// decimal totalLightBulbs = squareMeter / quotientX;

// //SAIDA DE DADOS
// Console.WriteLine("Para iluminar o cômodo: " + convenient + " com " + squareMeter.ToString("N2") + " metros quadrados " + "será necessario a instalação de " + totalLightBulbs.ToString("N2") + " lâmpada(s)");

//obs: Observe que foi utilizado um recurso para controle de casas decimais na saída de dados, mostrando apenas duas casas decimais em squareMeter.ToString("N2") e totalLightBulbs.ToString("N2")

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
