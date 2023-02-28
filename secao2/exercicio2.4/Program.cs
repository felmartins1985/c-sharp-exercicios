using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite a hora inicial do jogo:");
      int horaInicial = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a hora final do jogo:");
      int horaFinal = int.Parse(Console.ReadLine());
      int duracao = 0;
      if (horaInicial < horaFinal)
      {
        duracao = horaFinal - horaInicial;
      }
      else
      {
        duracao = 24 - horaInicial + horaFinal;
      }
      Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
    }

  }
}

