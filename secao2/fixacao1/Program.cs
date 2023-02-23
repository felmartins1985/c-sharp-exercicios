using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      string produto1 = "Computador";
      string produto2 = "Mesa de escritório";
      byte idade = 30;
      int codigo = 5290;
      char genero = 'M';
      double preco1 = 2100.0;
      double preco2 = 650.50;
      double medida = 53.234567;
      System.Console.WriteLine( "Produtos:");
      System.Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
      System.Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
      System.Console.WriteLine("Registro: {0} anos de idade, codigo {1} e genero: {2}", idade, codigo, genero);
      System.Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
      System.Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
      System.Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));

    }   
  }
}
