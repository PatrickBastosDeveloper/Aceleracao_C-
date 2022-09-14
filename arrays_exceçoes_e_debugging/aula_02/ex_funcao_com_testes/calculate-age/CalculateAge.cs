namespace Agenamespace
{
  public class AgeCalculator
  {
    public int yourAgeIs;
    public static int CalculateAgeByYear(int yearOfBirth)
    {
      int yourAgeIs = DateTime.Now.Year - yearOfBirth;
      Console.WriteLine($"Sua idade é: {yourAgeIs}");
      return yourAgeIs;
    }

    public static bool ValidateComingOfAge(int age)
    {
      return age >= 18;
    }
  }
}