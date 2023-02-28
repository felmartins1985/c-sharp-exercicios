using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite x: ");
      double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Digite y: ");
      double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      if (x == 0 && y == 0)
      {
        Console.WriteLine("Origem");
      }
      else if (x == 0)
      {
        System.Console.WriteLine("Eixo Y");
      }
      else if (y == 0)
      {
        System.Console.WriteLine("Eixo X");
      }
      else if (x > 0 && y > 0){
        System.Console.WriteLine("Q1");
      }
      else if( x>0 && y<0){
        System.Console.WriteLine("Q4");
      }
      else if (x<0 && y>0){
        System.Console.WriteLine("Q2");
      }
      else if (x<0 && y<0){
        System.Console.WriteLine("Q3");
      }
      else
      {
        System.Console.WriteLine("Origem");
      }
    }

  }
}

