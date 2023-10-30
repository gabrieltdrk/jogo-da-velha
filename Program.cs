using System.Reflection.Metadata.Ecma335;
using System.Text;

class Tic_Tac_Moji
{

    public string Player1 { get; set; }
    public string Player2 { get; set; }
    public string Emoji1 { get; set; }
    public string Emoji2 { get; set; }

    // CONSTRUIR O JOGO COM OS NOMES PARA COMEÇARMOS A ESCOLHER A VEZ, DECIDIR QUEM GANHA, ETC
    public Tic_Tac_Moji(string Player1, string Emoji1, string Player2, string Emoji2)
    {
        this.Player1 = Player1;
        this.Emoji1 = Emoji1;
        this.Player2 = Player2;
        this.Emoji2 = Emoji2;
    }

    // INÍCIO DO JOGO - NA VEZ INFORMADA, O JOGADOR DEVERÁ INPUTAR UM DOS NÚMEROS PARA PREENCHER.
    string[,] game = new string[3, 3]
    {
            {"1", "2", "3" },
            {"4", "5", "6" },
            {"7", "8", "9" },
    };

    public string ChooseTurn()
    {
        Random random = new Random();
        int p1 = random.Next();
        int p2 = random.Next();
        return p1 > p2 ?  $"É a sua vez, {this.Player1}, você é o {this.Emoji1}" : $"É a sua vez, {this.Player2}, você é o {this.Emoji2}";
    }

    public void SlowText()
    {
        string texto = "Agora, o jogo decidirá quem irá começar...";

        foreach (char c in texto)
        {
            Console.Write(c);
            Thread.Sleep(100); // Atraso de 100 milissegundos (0,1 segundo)
        }

        foreach (char c in ChooseTurn())
        {
            Console.Write(c);
            Thread.Sleep(100); // Atraso de 100 milissegundos (0,1 segundo)
        }

        Console.WriteLine();
    }

    public void ShowGame()
    {
        Console.WriteLine("");
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
        Console.InputEncoding = Encoding.UTF8; // FAZER COM QUE O CONSOLE POSSA INSERIR EMOJIS;
        Console.OutputEncoding = Encoding.Unicode; // FAZER COM QUE O CONSOLE POSSA MOSTRAR EMOJIS;

        string player1, player2, emoji1, emoji2;
        Console.Write("Insira o nome do primeiro jogador: ");
        player1 = Console.ReadLine();
        Console.Write("Insira o nome do emoji que usará (APERTE WINDOWS + PONTO PARA ESCOLHER): ");
        emoji1 = Console.ReadLine();

        Console.Write("Insira o nome do segundo jogador: ");
        player2 = Console.ReadLine();
        Console.Write("Insira o nome do emoji que usará (APERTE WINDOWS + PONTO PARA ESCOLHER): ");
        emoji2 = Console.ReadLine();


        Tic_Tac_Moji NewGame = new Tic_Tac_Moji(player1, emoji1, player2, emoji2);


        Console.WriteLine("Pressione qualquer tecla para começar...");
        Console.Write(emoji1);
        Console.Write(emoji2);
        Console.ReadKey(true);

        NewGame.SlowText();



        //do
        //{

        //} while (true);

    }
}