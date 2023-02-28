using System;
using System.Globalization;
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite a senha correta: ");
      int password = int.Parse(Console.ReadLine());
      while (password != 2002)
      {
        System.Console.WriteLine("Senha incorreta");
        Console.Write("Digite a senha correta: ");
        password = int.Parse(Console.ReadLine());
      }
      System.Console.WriteLine("Acesso permitido");
    }
  }
}