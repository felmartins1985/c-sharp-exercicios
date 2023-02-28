using System;
using System.Globalization;

namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite um numero ");
      int n = int.Parse(Console.ReadLine());
      int soma = 1;
      for (int i= n; i > 0; i--)
      {
        soma *= i;
      }
      System.Console.WriteLine($"O valor fatorial foi {soma}");

      }
  }
}
