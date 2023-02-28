using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite um numero: ");
      int numero1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite outro numero: ");
      int numero2 = int.Parse(Console.ReadLine());
      if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
      {
        Console.WriteLine("Sao multiplos");
      }
      else
      {
        Console.WriteLine("Nao sao multiplos");
      }
    }
  }
}

