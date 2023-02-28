using System;
using System.Globalization;
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite como deseja abastecer: ");
      int alcool = 0;
      int gasolina = 0;
      int diesel = 0;
      int combustivel = int.Parse(Console.ReadLine());
      while (combustivel != 4)
      {
        if (combustivel == 1)
        {
          alcool += 1;
        }
        else if (combustivel == 2)
        {
          gasolina += 1;
        }
        else if (combustivel == 3)
        {
          diesel += 1;
        }
        else
        {
          System.Console.WriteLine("Código inválido: digite novamente");
        }
        combustivel = int.Parse(Console.ReadLine());

      }
      Console.WriteLine("MUITO OBRIGADO");
      Console.WriteLine("Alcool: " + alcool);
      Console.WriteLine("Gasolina: " + gasolina);
      Console.WriteLine("Diesel: " + diesel);

    }
  }
}
