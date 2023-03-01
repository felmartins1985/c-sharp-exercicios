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
      for (int i = 1; i <= n; i++)
      {
        if (n % i == 0)
        {
          System.Console.WriteLine($" O {n} e divisivel por {i}");

        }
      }

    }
  }
}
