using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Start(int tempo)
        {
            int tempoAtual = 0;

            while (tempoAtual < tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado.");
            Thread.Sleep(1000);
            Console.WriteLine("Retornando ao menu");
            Thread.Sleep(1000);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = dez segundos");
            Console.WriteLine("M = Minuto => 1m = um minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar: ");
            string dados = Console.ReadLine().ToLower();

            if (dados == "0" || dados == "0s")
                System.Environment.Exit(0);

            int totalDeCaracteres = dados.Length;

            char unidadeTempo = char.Parse(dados.Substring((totalDeCaracteres - 1), 1));

            int tempo = int.Parse(dados.Substring(0, (totalDeCaracteres - 1)));

            int multiplicador = 1;

            if (unidadeTempo == 'm')
                multiplicador *= 60;

            PreStart(tempo * multiplicador);
        }

        static void PreStart(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Vai!");
            Thread.Sleep(500);
            Start(tempo);
        }
    }
}
