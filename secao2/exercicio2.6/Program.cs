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
      double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      if (numero >= 0 && numero <= 25)
      {
        Console.WriteLine("Intervalo [0,25]");
      }
      else if (numero >25 &&  numero <= 50 ){
        Console.WriteLine("Intervalo (25,50]");
      }
      else if (numero > 50 && numero <= 75)
      {
        Console.WriteLine("Intervalo (50,75]");
      }
      else if (numero > 75 && numero <= 100)
      {
        Console.WriteLine("Intervalo (75,100]");
      }
      else
      {
        Console.WriteLine("Fora de intervalo");
      }

    }

  }
}

