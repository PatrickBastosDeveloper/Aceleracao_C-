//////ex1//////
// var count = 0;

// while(count < 5){
// Console.WriteLine(count);
// count++;
// }

//////ex2//////
// var count = 5;
// do
// {
//   Console.WriteLine(count);
//   count++;
// } while (count < 10);

//////ex3//////
// for(int count = 0; count < 5; count++){
//   Console.WriteLine(count);
// };

//////ex4//////
// string[] names = new string[] { "Hulk", "Thor", "Loki" };

// foreach(var name in names) {
//   Console.WriteLine(name);
// }

//////ex5//////
// string[] teachers = new string[] { "Joel", "Tess", "Marlene" };
// string[] students = new string[] { "Ellie", "Joel", "Abby" };
// foreach (var teacher in teachers)
// {
//     Console.WriteLine("Professor: " + teacher + ". Estudante:");
//     foreach (var student in students)
//     {               
//         if (teacher == student)
//             break;
//         Console.WriteLine(student);
//     }
// }  

//////ex5//////
// Obs: O exemplo considera números menores que três como voto válido.

// int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2 };

// int count = 0;

// foreach (int vote in votes)
// {
//   if (vote > 3)
//   {
//     continue;
//   }

//   count++;
// }
// Console.WriteLine(count +"votos válidos");

//O laço foreach percorrerá todos os itens do array verificando se o valor do mesmo é maior que três. Se for, fará uso da instrução continue para saltar a iteração do laço. Dessa forma a variável count só será incrementada para votos válidos.
