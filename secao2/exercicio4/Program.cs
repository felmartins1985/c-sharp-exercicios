using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      int number = int.Parse(Console.ReadLine());
      int hours = int.Parse(Console.ReadLine());
      double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double salary = hours * valuePerHour;
      Console.WriteLine("NUMBER = " + number);
      Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
