using System;
using System.Globalization;
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite a quantidade de testes ");
      int N = int.Parse(Console.ReadLine());
      double saida = 0;
      for (int i = 1; i <= N; i++)
      {
        Console.Write("Digite um numero ");
        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (i == 1)
        {
          saida += numero * 2;
        }
        else if (i == 2)
        {
          saida += numero * 3;
        }
        else
        {
          saida += numero * 5;
        }

      }
      double resultado = saida / 10;
      System.Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
      // for (int i = 0; i < n; i++)
      // {

      //   string[] line = Console.ReadLine().Split(' ');
      //   double a = double.Parse(line[0], CultureInfo.InvariantCulture);
      //   double b = double.Parse(line[1], CultureInfo.InvariantCulture);
      //   double c = double.Parse(line[2], CultureInfo.InvariantCulture);

      //   double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

      //   Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
      // }
    }
  }
}


