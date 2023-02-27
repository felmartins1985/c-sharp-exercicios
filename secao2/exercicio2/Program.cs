using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double pi = 3.14159;
      double area = pi * (raio * raio);
      Console.WriteLine("A= " + area.ToString("F4", CultureInfo.InvariantCulture));
    }
  }
}
