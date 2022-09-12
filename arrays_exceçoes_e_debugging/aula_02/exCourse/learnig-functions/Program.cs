using ContainerCalculateBMI;


namespace Exercises
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      CalculateBMI putValue = new();
      putValue.Calculate(50, 1.80);
      CalculateBMI.TesteFunc("ok");
      // Console.WriteLine("Boas vindas!");
    }
  }
}