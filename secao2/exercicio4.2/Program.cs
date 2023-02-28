using System;
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite a quantidade de numeros ");
      int N = int.Parse(Console.ReadLine());
      int count_in=0;
      int count_out=0;
      for (int i = 1; i <= N && i <= 1000; i++)
      {
        Console.Write("Digite um numero ");
        int numero = int.Parse(Console.ReadLine());
        if (numero >= 10 && numero <=20)
        {
          count_in++;
        }
        else {
          count_out++;
        }
      }
      System.Console.WriteLine(count_in + " in");
      System.Console.WriteLine(count_out + " out");
    }
  }
}


