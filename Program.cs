using System.Data.Common;
using System.Runtime.Intrinsics.Arm;

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
    public string[,] Game = new string[3, 3]
    {
            {"1", "2", "3" },
            {"4", "5", "6" },
            {"7", "8", "9" },
    };
    // ESCOLHER QUEM COMEÇA
    public int ChooseTurn(ref int turn)
    {
        Random random = new Random();
        int p1 = random.Next();
        int p2 = random.Next();
        if (p1 > p2)
        {
            Console.WriteLine($"É a sua vez, {this.Player1}, você é o {this.Emoji1}");
            ShowGame();
            return turn = 1;
        }
        else
        {
            Console.WriteLine($"É a sua vez, {this.Player2}, você é o {this.Emoji2}");
            ShowGame();
            return turn = 2;
        }
    }

    // TROCAR O TURNO
    public void ChangeTurn(ref int turn)
    {
        if (turn == 1)
        {
            Console.WriteLine("");
            Console.WriteLine($"Agora é a vez do {this.Player2}! Seu emoji, é: {this.Emoji2}");
            turn = 2;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"Agora é a vez do {this.Player1}! Seu emoji, é: {this.Emoji1}");
            turn = 1;
        }
    }

    // INPUTAR O EMOJI DO TURNO
    public void InputKey(ref int turn)
    {
        ChangeTurn(ref turn);
        ShowGame();
        do
        {
            string a;
            do
            {
                Console.Write("Informe um número a ser preenchido por emojis: ");
                a = Console.ReadLine();
            } while (a == string.Empty);

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (Game[row, column] == a && turn == 1)
                    {
                        Game[row, column] = this.Emoji1;
                    };
                    if (Game[row, column] == a && turn == 2)
                    {
                        Game[row, column] = this.Emoji2;
                    };
                }
            }
            ChangeTurn(ref turn);
            ShowGame();
        } while (!WinCondition());
    }

    public bool WinCondition()
    {
        Random random = new Random(3);
        string[] frases = { ", isso foi fácil demais, não?", ", boas jogadas resultam nessa vitória", ", molezinha em?!" };
        //for (int column = 0; column < 3; column++)
        //{
        //    if (Game[0, column] == this.Emoji1) {
        //        a++;
        //        if (a++ == 3) { return true; }
        //    } else if(Game[0, column] == this.Emoji2) {
        //        b++;
        //        if (b++ == 3) { return true; }
        //    }
        //}

        // PLAYER 1 (LINHAS)
        if (Game[0,0] == this.Emoji1 && Game[0,1] == this.Emoji1 && Game[0,2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
        if (Game[1,0] == this.Emoji1 && Game[1,1] == this.Emoji1 && Game[1,2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
        if (Game[2, 0] == this.Emoji1 && Game[2, 1] == this.Emoji1 && Game[2, 2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
        // PLAYER 1 (COLUNAS)
        if (Game[0, 0] == this.Emoji1 && Game[1, 0] == this.Emoji1 && Game[2, 0] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
        if (Game[0, 1] == this.Emoji1 && Game[1, 1] == this.Emoji1 && Game[2, 1] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
        if (Game[0, 2] == this.Emoji1 && Game[1, 2] == this.Emoji1 && Game[2, 2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
        // PLAYER 1 (X)
        if (Game[0, 0] == this.Emoji1 && Game[1, 1] == this.Emoji1 && Game[2, 2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
        if (Game[0, 2] == this.Emoji1 && Game[1, 1] == this.Emoji1 && Game[2, 0] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }

        // PLAYER 2 (LINHAS)
        if (Game[0, 0] == this.Emoji2 && Game[0, 1] == this.Emoji2 && Game[0, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
        if (Game[1, 0] == this.Emoji2 && Game[1, 1] == this.Emoji2 && Game[1, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
        if (Game[2, 0] == this.Emoji2 && Game[2, 1] == this.Emoji2 && Game[2, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
        // PLAYER 2 (COLUNAS)
        if (Game[0, 0] == this.Emoji2 && Game[1, 0] == this.Emoji2 && Game[2, 0] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
        if (Game[0, 1] == this.Emoji2 && Game[1, 1] == this.Emoji2 && Game[2, 1] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
        if (Game[0, 2] == this.Emoji2 && Game[1, 2] == this.Emoji2 && Game[2, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
        // PLAYER 2 (X)
        if (Game[0, 0] == this.Emoji2 && Game[1, 1] == this.Emoji2 && Game[2, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
        if (Game[0, 2] == this.Emoji2 && Game[1, 1] == this.Emoji2 && Game[2, 0] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
        return false;
    }

    public void SlowText(string texto, bool clear)
    {
        if (clear) { Console.Clear(); }
        foreach (char c in texto)
        {
            Console.Write(c);
            Thread.Sleep(50); // Atraso de 100 milissegundos (0,1 segundo)
        }
        Console.WriteLine();
        Thread.Sleep(3000);
    }
    public void ShowGame()
    {
        Console.WriteLine("");
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                Console.Write(Game[row, column] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode; // FAZER COM QUE O CONSOLE POSSA INSERIR EMOJIS;
        Console.OutputEncoding = System.Text.Encoding.Unicode; // FAZER COM QUE O CONSOLE POSSA MOSTRAR EMOJIS;
        int turn = 0; // VEZ DE QUEM COMEÇA;

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

        NewGame.SlowText("Seja bem-vindo ao Tic-Tac-Moji, um jogo da velha com emojis.", true);
        NewGame.SlowText("A seguir, o jogo decidirá aleatoriamente quais dos jogadores começará a partida, assim, deverão utilizar os números de " +
            "1 a 9, para substituir os números das casas, por emoji.", true);

        NewGame.InputKey(ref turn);

    }
}