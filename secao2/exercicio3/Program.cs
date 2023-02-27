using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      int A= int.Parse(Console.ReadLine());
      int B= int.Parse(Console.ReadLine());
      int C= int.Parse(Console.ReadLine());
      int D= int.Parse(Console.ReadLine());
      int diferenca = (A * B - C * D);
      Console.WriteLine("DIFERENCA = " + diferenca);
    }
  }
}
