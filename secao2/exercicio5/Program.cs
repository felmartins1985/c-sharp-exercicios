using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite sobre a primeira peca: ");
      string[] peca1 = Console.ReadLine().Split(' ');
      int codigo1 = int.Parse(peca1[0]);
      int quantidade1 = int.Parse(peca1[1]);
      double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
      double soma1= quantidade1 * valor1;
      Console.WriteLine("Digite sobre a segunda peca: ");
      string[] peca2 = Console.ReadLine().Split(' ');
      int codigo2 = int.Parse(peca2[0]);
      int quantidade2 = int.Parse(peca2[1]);
      double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
      double soma2= quantidade2 * valor2;
      double total = soma1 + soma2;
      Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
