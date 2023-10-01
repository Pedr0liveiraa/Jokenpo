using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpô
{
    public class Jokenpo
    {
        private readonly string[] jogadas = { "Pedra", "Papel", "Tesoura", "Sair" };
        Random random = new Random();
        int vitorias_player = 0;
        int vitorias_computador = 0;
        int empates = 0;

        public void run_game(string playerName)
        {
            while(true)
            {
                Console.WriteLine($"Selecione sua jogada, {playerName}\n");
                for (int i = 0; i < jogadas.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + jogadas[i]);
                }
                Console.Write("\nSua jogada: ");
                int player_jogada = int.Parse(Console.ReadLine());
                
                if(player_jogada == 4)
                {
                    Console.WriteLine($"\n\nObrigado por jogar, {playerName}.\nVocê terminou com {vitorias_player} vitórias" +
                        $", {vitorias_computador} derrotas e {empates} empates.");
                    break;
                }
                
                int computador_jogada = random.Next(1, 4);

                if(player_jogada < 1 || player_jogada > 4)
                {
                    Console.WriteLine("Ação impossível.");
                }
                else if(player_jogada == 1 && computador_jogada == 3 ||
                    player_jogada == 2 && computador_jogada == 1 ||
                    player_jogada == 3 && computador_jogada == 2)
                {
                    Console.WriteLine("Você ganhou!");
                    vitorias_player++;
                }
                else if(player_jogada == computador_jogada)
                {
                    Console.WriteLine("Empate!");
                    empates++;
                }
                else
                {
                    Console.WriteLine("Perdeu!");
                    vitorias_computador++;
                }

                Console.WriteLine($"\n\nVitórias: {vitorias_player}\nDerrotas: {vitorias_computador}\nEmpates: {empates}\n\n");
            }
        }
    }
}
