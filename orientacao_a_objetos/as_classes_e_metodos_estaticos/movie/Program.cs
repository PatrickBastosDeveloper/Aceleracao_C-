namespace cine;

class Program 
{
  public static void Main(string[] args){
    var movie = new Movie("Matrix", "Ficção Científica");
    var movie2 = new Movie("Senhor dos Aneis", "Fantasia");

    Console.WriteLine(movie.Title);
    Console.WriteLine(movie.Category);

    Console.WriteLine(movie2.Title);
    Console.WriteLine(movie2.Category);

    movie.Title = "Matrix 2";
    movie.Category = "Pudim"; // Exception lançada no terminal!!!

    Console.WriteLine(movie.Title);
    Console.WriteLine(movie.Category);
  }
}