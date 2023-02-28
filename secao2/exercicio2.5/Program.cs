using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite o codigo do item que deseja:");
      int codigo = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a quantidade que deseja:");
      int quantidade = int.Parse(Console.ReadLine());
      double total = 0.0;
      if (codigo == 1)
      {
        total = quantidade * 4.0;
      }
      else if (codigo == 2)
      {
        total = quantidade * 4.5;
      }
      else if (codigo == 3)
      {
        total = quantidade * 5.0;
      }
      else if (codigo == 4)
      {
        total = quantidade * 2.0;
      }
      else if (codigo == 5)
      {
        total = quantidade * 1.5;
      }
      Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }

  }
}

