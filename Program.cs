using System;

namespace Aula18Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("|-------------------|");
            System.Console.WriteLine("|-------------------|");
            System.Console.WriteLine("|--DADOS DO JOGADOR-|");
            System.Console.WriteLine("|-------------------|");
            System.Console.WriteLine("|-------------------|");

            Jogador jogador = new Jogador();

            jogador.MostrarDados();
            Console.WriteLine(jogador.CalcularIdade( ));
            Console.WriteLine(jogador.VerificarAposentadoria( ));
            
        }
    }
}
