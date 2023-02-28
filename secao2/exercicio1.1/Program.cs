using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
     int n1= int.Parse(Console.ReadLine());
     int n2= int.Parse(Console.ReadLine());
     Console.WriteLine("SOMA = " + (n1+n2));
    }
  }
}
