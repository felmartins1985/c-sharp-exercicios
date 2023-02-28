using System;
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite um numero ");
      int N = int.Parse(Console.ReadLine());
      for (int i = 1; i <= N && i <= 1000; i++)
      {
        if (i % 2 != 0)
        {
          System.Console.WriteLine(i);
        }
      }
    }
  }
}

