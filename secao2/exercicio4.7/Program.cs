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
      // int quadrado = 0;
      // int cubo = 0;
      for (int i = 1; i <= n; i++)
      {
        int quadrado= i * i;
        int cubo = i * i * i;
        System.Console.WriteLine($"{i} {quadrado} {cubo}");
      }

    }
  }
}
