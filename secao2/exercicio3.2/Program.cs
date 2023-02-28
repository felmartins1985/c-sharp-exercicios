using System;
using System.Globalization;
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite a coordenada x: ");
      int x = int.Parse(Console.ReadLine());
      Console.Write("Digite a coordenada y: ");
      int y = int.Parse(Console.ReadLine());
      while (x != 0 && y!=0){
        if (x>0 && y>0){
          System.Console.WriteLine("Primeiro");   
        }
        else if (x >0 && y<0){
          System.Console.WriteLine("Quarto");
        }
        else if (x<0 && y>0){
          System.Console.WriteLine("Segundo");
        }
        else {
          System.Console.WriteLine("Terceiro");
        }
        System.Console.WriteLine("Digite a coordenada x: ");
        x = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite a coordenada y: ");
        y = int.Parse(Console.ReadLine());
      }

    }
  }
}
