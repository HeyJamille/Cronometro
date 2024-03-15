using System;
using System.Threading;

namespace Cronometro
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Menu();
    }

    // Método PreStart
    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("Go...");
      Thread.Sleep(2500);

      Start(time);
    }

    // Método Start
    static void Start(int time)
    {
      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000); // Dormir por 1 segundo
      }

      Console.Clear();
      Console.WriteLine("Cronômetro finalizado");
      Thread.Sleep(2500);
      Menu();
    }

    // Método Menu
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Escolha uma opção:");
      Console.WriteLine("1 - Segundo => 10s = 10 segundos \n" +
                        "2 - Minuto => 1m = 1 minuto \n" +
                        "0 - Sair \n");
      Console.Write("Quanto tempo deseja contar? ");

      string opcao = Console.ReadLine().ToLower();
      char type = char.Parse(opcao.Substring(opcao.Length - 1, 1)); // Converte a string em char e pega o ultimo elemento da string
      int time = int.Parse(opcao.Substring(0, opcao.Length - 1)); // Converte a string em int e pega todos os números menos o caracter
      int multiplier = 1;

      if (type == 'm')
        multiplier = 60;

      if (time == 0)
        System.Environment.Exit(0);

      PreStart(time * multiplier);
    }
  }
}
