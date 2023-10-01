namespace Jokenpô
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n========== Pedra, Papel e Tesoura ==========\n");
            Console.Write("Escreva seu Nome: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("\n============================================\n");
            
            Jokenpo jogo = new Jokenpo();
            jogo.run_game(playerName);
        }
    }
}