using Agenamespace;

namespace CalculateAge
{
  class Program
  {
    public static void Main()
    {
      int age = AgeCalculator.CalculateAgeByYear(1987);
      bool result = AgeCalculator.ValidateComingOfAge(age);
      if (!result)
      {
        Console.WriteLine("Você não tem idade para entrar.");
      }
      else
      {
        Console.WriteLine("Você pode entrar.");
      }
    }
  }
}
