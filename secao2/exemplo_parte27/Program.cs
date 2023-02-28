using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Qual a hora atual?");
      int hora = int.Parse(Console.ReadLine());
      if (hora < 12)
      {
        Console.WriteLine("Bom dia!");
      }
      else if (hora < 18)
      {
        Console.WriteLine("Boa tarde!");
      }
      else
      {
        Console.WriteLine("Boa noite!");
      }
    }
  }
}

