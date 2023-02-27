using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Entre com seu nome completo: ");
      string fullName = Console.ReadLine();
      Console.WriteLine("Quantos quartos tem na sua casa? ");
      int rooms= int.Parse(Console.ReadLine());
      Console.WriteLine("Entre com o preço de um produto: ");
      double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
      string[] data = Console.ReadLine().Split(' ');
      string lastName = data[0];
      int age = int.Parse(data[1]);
      double height = double.Parse(data[2], CultureInfo.InvariantCulture);
      Console.WriteLine("Você digitou:");
      Console.WriteLine(fullName);
      Console.WriteLine(rooms);
      Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine(lastName);
      Console.WriteLine(age);
      Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

    }
  }
}
