public class Player
{
    string name { get; set; }
    public Player(string name)
    {
        this.name = name;
    }
}

class Tic_Tac_Toe
{
    string[,] game = new string[3, 3]
        {
            {"1", "2", "3" },
            {"4", "5", "6" },
            {"7", "8", "9" },
        };

    public void showGame()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                Console.Write(game[row, column] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o nome do primeiro jogador: ");
        Player jogador1 = new Player(Console.ReadLine());

        Console.Write("Insira o nome do segundo jogador: ");
        Player jogador2 = new Player(Console.ReadLine());

        Console.WriteLine("Pressione qualquer tecla para começar...");
        Console.ReadKey(true);
        
    }
}