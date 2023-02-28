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
      int numero = int.Parse(Console.ReadLine());
      if (numero < 0)
      {
        Console.WriteLine("NEGATIVO");
      }
      else
      {
        Console.WriteLine("NAO NEGATIVO");
      }

    }
  }
}

