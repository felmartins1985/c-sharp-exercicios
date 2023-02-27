using System;
using System.Globalization; // necessario para formatar a saida de dados, colocando o ponto
// ao inves de virgulas para numeros decimais --> CultureInfo.InvariantCulture
namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
        sbyte x= 100;
        // byte n1 = -1; não aceita negativo porque a tipagem do byte é positiva
        // byte n1 =256; // aceita até 255
        byte n1 =126;
        int n2 = 1000;
        int n3 = 2147483647;
        long n4 = 2147483648L;// o L é para informar que é um numero Long
        bool completo= false;
        char genero = 'F'; // guarda um caracter unicode e precisa colocar entre aspas simples
        char letra = '\u0041'; // o \u é para informar que é um caracter unicode
        float n5 = 4.5f; // o f é para informar que é um numero float, se nao ele confunde com o tipo double
        double n6 = 4.5; // o doble é o tipo padrão para numeros decimais
        string nome = "Maria Green"; // precisa colocar aspas duplas e ela e IMUTAVEL
        object obj1 = "Alex Brown"; // e um objeto generico. Toda classe em C# herda de object
        // o object aceita qualquer tipo
        int n7 = int.MinValue; // mostra o valor minimo do tipo int
        int n8 = int.MaxValue; // mostra o valor maximo do tipo int

        Console.WriteLine(n1);
        Console.WriteLine(x);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(completo);
        Console.WriteLine(genero);
        Console.WriteLine(letra);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
        Console.WriteLine(nome);
        Console.WriteLine(obj1);
        Console.WriteLine(n7);
        Console.WriteLine(n8);
        Console.WriteLine("--------------------------");
      char genero1= 'F';
      int idade = 32;
      double saldo = 10.35784;
      string nome1 = "Maria";
      Console.Write("Bom dia!");
      Console.WriteLine("Boa tarde!");
      Console.WriteLine("Boa noite!");
      Console.WriteLine(genero1);
      Console.WriteLine(idade);
      Console.WriteLine(saldo);
      Console.WriteLine(nome1);
      Console.WriteLine(saldo.ToString("F2")); 
      // o ToString("F2") e para limitar a quantidade de casas decimais e arredonda
      Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
      Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome1, idade, saldo);
      //placeholders
      // os numeros entre {} servem para indicar a ordem dos parametros que serao passados na frase
      // o F2 e para limitar a quantidade de casas decimais e arredonda
      Console.WriteLine($"{nome1} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
      // interpolacao
      Console.WriteLine(nome1 + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
      // concatenacao
      Console.WriteLine("--------------------------");
      string frase2= Console.ReadLine();
      string x2 = Console.ReadLine();
      string y2 = Console.ReadLine();
      string z2 = Console.ReadLine();
      string[] vetores= Console.ReadLine().Split(' ');
      string vetor1 = vetores[0];
      string vetor2 = vetores[1];
      string vetor3 = vetores[2];
      System.Console.WriteLine("Você digitou: ");
      System.Console.WriteLine(frase2);
      System.Console.WriteLine(x2);
      System.Console.WriteLine(y2);
      System.Console.WriteLine(z2);
      System.Console.WriteLine(vetor1);
      System.Console.WriteLine(vetor2);
      System.Console.WriteLine(vetor3);
      
    }   
  }
}
