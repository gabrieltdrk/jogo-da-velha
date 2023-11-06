//class Tic_Tac_Moji
//{

//    public string Player1 { get; set; }
//    public string Player2 { get; set; }
//    public string Emoji1 { get; set; }
//    public string Emoji2 { get; set; }

//    // CONSTRUIR O JOGO COM OS NOMES PARA COMEÇARMOS A ESCOLHER A VEZ, DECIDIR QUEM GANHA, ETC
//    public Tic_Tac_Moji(string Player1, string Emoji1, string Player2, string Emoji2)
//    {
//        this.Player1 = Player1;
//        this.Emoji1 = Emoji1;
//        this.Player2 = Player2;
//        this.Emoji2 = Emoji2;
//    }

//    // INÍCIO DO JOGO - NA VEZ INFORMADA, O JOGADOR DEVERÁ INPUTAR UM DOS NÚMEROS PARA PREENCHER.
//    public string[,] Game = new string[3, 3]
//    {
//            {"1", "2", "3" },
//            {"4", "5", "6" },
//            {"7", "8", "9" },
//    };
//    // ESCOLHER QUEM COMEÇA
//    public int ChooseTurn(ref int turn)
//    {
//        Random random = new Random();
//        int p1 = random.Next();
//        int p2 = random.Next();
//        if (p1 > p2)
//        {
//            Console.WriteLine($"É a sua vez, {this.Player1}, você é o {this.Emoji1}");
//            ShowGame();
//            return turn = 1;
//        }
//        else
//        {
//            Console.WriteLine($"É a sua vez, {this.Player2}, você é o {this.Emoji2}");
//            ShowGame();
//            return turn = 2;
//        }
//    }

//    // TROCAR O TURNO
//    public void ChangeTurn(ref int turn)
//    {
//        if (turn == 1)
//        {
//            Console.WriteLine("");
//            Console.WriteLine($"Agora é a vez do {this.Player2}! Seu emoji, é: {this.Emoji2}");
//            turn = 2;
//        }
//        else
//        {
//            Console.WriteLine("");
//            Console.WriteLine($"Agora é a vez do {this.Player1}! Seu emoji, é: {this.Emoji1}");
//            turn = 1;
//        }
//    }

//    // INPUTAR O EMOJI DO TURNO
//    public void InputKey(ref int turn)
//    {
//        ChooseTurn(ref turn);
//        do
//        {
//            string a;
//            do
//            {
//                Console.Write("Informe um número a ser preenchido por emojis: ");
//                a = Console.ReadLine();
//            } while (a == string.Empty);

//            for (int row = 0; row < 3; row++)
//            {
//                for (int column = 0; column < 3; column++)
//                {
//                    if (Game[row, column] == a && turn == 1)
//                    {
//                        Game[row, column] = this.Emoji1;
//                        ChangeTurn(ref turn);
//                        ShowGame();
//                    }; 
//                    if (Game[row, column] == a && turn == 2)
//                    {
//                        Game[row, column] = this.Emoji2;
//                        ChangeTurn(ref turn);
//                        ShowGame();
//                    };
//                }
//            }

//        } while (!WinCondition());
//    }

//    public bool WinCondition()
//    {
//        Random random = new Random(3);
//        string[] frases = { ", isso foi fácil demais, não?", ", boas jogadas resultam nessa vitória", ", molezinha em?!" };
//        //for (int column = 0; column < 3; column++)
//        //{
//        //    if (Game[0, column] == this.Emoji1) {
//        //        a++;
//        //        if (a++ == 3) { return true; }
//        //    } else if(Game[0, column] == this.Emoji2) {
//        //        b++;
//        //        if (b++ == 3) { return true; }
//        //    }
//        //}

//        // PLAYER 1 (LINHAS)
//        if (Game[0,0] == this.Emoji1 && Game[0,1] == this.Emoji1 && Game[0,2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
//        if (Game[1,0] == this.Emoji1 && Game[1,1] == this.Emoji1 && Game[1,2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
//        if (Game[2, 0] == this.Emoji1 && Game[2, 1] == this.Emoji1 && Game[2, 2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
//        // PLAYER 1 (COLUNAS)
//        if (Game[0, 0] == this.Emoji1 && Game[1, 0] == this.Emoji1 && Game[2, 0] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
//        if (Game[0, 1] == this.Emoji1 && Game[1, 1] == this.Emoji1 && Game[2, 1] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
//        if (Game[0, 2] == this.Emoji1 && Game[1, 2] == this.Emoji1 && Game[2, 2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
//        // PLAYER 1 (X)
//        if (Game[0, 0] == this.Emoji1 && Game[1, 1] == this.Emoji1 && Game[2, 2] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }
//        if (Game[0, 2] == this.Emoji1 && Game[1, 1] == this.Emoji1 && Game[2, 0] == this.Emoji1) { Console.WriteLine($"Parabéns, o {this.Player1} ganhou!!! {this.Emoji1} {this.Emoji1} {this.Emoji1}"); return true; }

//        // PLAYER 2 (LINHAS)
//        if (Game[0, 0] == this.Emoji2 && Game[0, 1] == this.Emoji2 && Game[0, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
//        if (Game[1, 0] == this.Emoji2 && Game[1, 1] == this.Emoji2 && Game[1, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
//        if (Game[2, 0] == this.Emoji2 && Game[2, 1] == this.Emoji2 && Game[2, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
//        // PLAYER 2 (COLUNAS)
//        if (Game[0, 0] == this.Emoji2 && Game[1, 0] == this.Emoji2 && Game[2, 0] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
//        if (Game[0, 1] == this.Emoji2 && Game[1, 1] == this.Emoji2 && Game[2, 1] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
//        if (Game[0, 2] == this.Emoji2 && Game[1, 2] == this.Emoji2 && Game[2, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
//        // PLAYER 2 (X)
//        if (Game[0, 0] == this.Emoji2 && Game[1, 1] == this.Emoji2 && Game[2, 2] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
//        if (Game[0, 2] == this.Emoji2 && Game[1, 1] == this.Emoji2 && Game[2, 0] == this.Emoji2) { Console.WriteLine($"Parabéns, o {this.Player2} ganhou!!! {this.Emoji2} {this.Emoji2} {this.Emoji2}"); return true; }
//        return false;
//    }

//    public void SlowText(string texto, bool clear)
//    {
//        if (clear) { Console.Clear(); }
//        foreach (char c in texto)
//        {
//            Console.Write(c);
//            Thread.Sleep(50);
//        }
//        Console.WriteLine();
//        Thread.Sleep(3000);
//    }
//    public void ShowGame()
//    {
//        Console.WriteLine("");
//        for (int row = 0; row < 3; row++)
//        {
//            for (int column = 0; column < 3; column++)
//            {
//                Console.Write(Game[row, column] + "\t");
//            }
//            Console.WriteLine();
//            Console.WriteLine("");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Title = "Tic-Tac-Moji";
//        Console.InputEncoding = System.Text.Encoding.UTF8; // FAZER COM QUE O CONSOLE POSSA INSERIR EMOJIS;
//        Console.OutputEncoding = System.Text.Encoding.Unicode; // FAZER COM QUE O CONSOLE POSSA MOSTRAR EMOJIS;
//        int turn = 0; // VEZ DE QUEM COMEÇA;

//        string player1, player2, emoji1, emoji2;
//        Console.Write("Insira o nome do primeiro jogador: ");
//        player1 = Console.ReadLine();
//        Console.Write("Insira o nome do emoji que usará (APERTE WINDOWS + PONTO PARA ESCOLHER): ");
//        emoji1 = Console.ReadLine();

//        Console.Write("Insira o nome do segundo jogador: ");
//        player2 = Console.ReadLine();
//        Console.Write("Insira o nome do emoji que usará (APERTE WINDOWS + PONTO PARA ESCOLHER): ");
//        emoji2 = Console.ReadLine();


//        Tic_Tac_Moji NewGame = new Tic_Tac_Moji(player1, emoji1, player2, emoji2);

//        //NewGame.SlowText("Seja bem-vindo ao Tic-Tac-Moji, um jogo da velha com emojis.", true);
//        //NewGame.SlowText("A seguir, o jogo decidirá aleatoriamente quais dos jogadores começará a partida, assim, deverão utilizar os números de " +
//        //    "1 a 9, para substituir os números das casas, por emoji.", true);

//        NewGame.InputKey(ref turn);

//    }
//}
public class Tic_Tac_Moji
{
    public string[] Player { get; set; } = { "", "" };
    public string[] Emoji { get; set; } = { "", "" };

    public string[,] Game = new string[3, 3]
    {
            {"1", "2", "3" },
            {"4", "5", "6" },
            {"7", "8", "9" },
    };

    public void SlowText(string text, bool clear)
    {
        if (clear) { Console.Clear(); }

        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Thread.Sleep(3000);
        Console.WriteLine("");
    }

    public void StartGame()
    {
        SlowText("Seja bem-vindo ao Tic-Tac-Moji, um jogo da velha de emojis.".ToUpper(), true);
        SlowText("Aqui, será possível informar os nomes dos jogadores e os emojis que serão utilizados durante a partida...".ToUpper(), true);
        SlowText("Para inputar seu emoji, basta apertar WINDOWS + PONTO e aparecerá a janela de emojis".ToUpper(), true);
        SlowText("Caso esteja utilizando o Windows 10 obrigatoriamente o 'emoji' deverá ser substituido por uma letra, pois o CMD não reconhece os emojis inputados".ToUpper(), true);
        SlowText("No windows 11, ao inputar os emojis, eles aparecem de forma bugada no console, porém, sua visualização durante o jogo fica normal!".ToUpper(), true);
        SlowText("Para inseri-lo na casa desejada, basta informar no console um número de 1-9 e apertar ENTER.".ToUpper(), true);
        ShowGame();
        Thread.Sleep(3000);
        Console.Clear();
        SlowText("Boa sorte aos dois jogadores!".ToUpper(), true);
        Console.Clear();
    }

    public void ShowInformations()
    {
        Console.Clear();
        SlowText($"Jogador 1 - {this.Player[0]}".ToUpper(), false);
        SlowText($"Emoji 1 - {this.Emoji[0]}".ToUpper(), false);
        Console.WriteLine("---------- x ----------");
        SlowText($"Jogador 2 - {this.Player[1]}".ToUpper(), false);
        SlowText($"Emoji 2 - {this.Emoji[1]}".ToUpper(), false);
        Thread.Sleep(3000);
        Console.Clear();
    }

    public int ChooseTurn(ref int turn)
    {
        Random random = new Random();
        int p1 = random.Next();
        int p2 = random.Next();

        if (p1 > p2)
        {
            return turn = 1;
        }
        else
        {
            return turn = 2;
        }
    }

    public void ChangeTurn(ref int turn)
    {
        if (turn == 1)
        {
            Console.WriteLine($"Sua vez {this.Player[0]}, seu emoji é: {this.Emoji[0]}");
            turn = 2;
        }
        else
        {
            Console.WriteLine($"Sua vez {this.Player[1]}, seu emoji é: {this.Emoji[1]}");
            turn = 1;
        }
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

    public void InputKey(ref int turn)
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
                if (Game[row, column] == a && turn == 2)
                {
                    Game[row, column] = this.Emoji[0];
                };
                if (Game[row, column] == a && turn == 1)
                {
                    Game[row, column] = this.Emoji[1];
                };
            }
        }
        Console.Clear();
    }

    public bool WinCondition(ref int rounds)
    {
        // TESTA AS CONDIÇÕES DE VITORIA POR COLUNA
        for (int row = 0; row < 3; row++)
        {
            int player1 = 0;
            int player2 = 0;
            for (int column = 0; column < 3; column++)
            {
                if (Game[row, column] == this.Emoji[0])
                {
                    player1++;
                    if (player1 == 3) { Console.WriteLine($"Parabéns {this.Player[0]}! Você venceu!"); return true; }
                }
                else if (Game[row, column] == this.Emoji[1])
                {
                    player2++;
                    if (player2 == 3) { Console.WriteLine($"Parabéns {this.Player[1]}! Você venceu!"); return true; }
                }
            }
        }
        // TESTA AS CONDIÇÕES DE VITORIA POR LINHA
        for (int column = 0; column < 3; column++)
        {
            int player1 = 0;
            int player2 = 0;
            for (int row = 0; row < 3; row++)
            {
                if (Game[row, column] == this.Emoji[0])
                {
                    player1++;
                    if (player1 == 3) { Console.WriteLine($"Parabéns {this.Player[0]}! Você venceu!"); return true; }
                }
                else if (Game[row, column] == this.Emoji[1])
                {
                    player2++;
                    if (player2 == 3) { Console.WriteLine($"Parabéns {this.Player[1]}! Você venceu!"); return true; }
                }
            }
        }
        // SOMA ROUNDS
        rounds++;
        // TESTA AS CONDICOES DE VITORIA CRUZADA
            // PLAYER 1
        if (Game[0, 0] == this.Emoji[0] && Game[1, 1] == this.Emoji[0] && Game[2, 2] == this.Emoji[0]) { Console.WriteLine($"Parabéns, o {this.Player[1]} ganhou!!! {this.Emoji[0]} {this.Emoji[0]} {this.Emoji[0]}"); return true; }
        if (Game[0, 2] == this.Emoji[0] && Game[1, 1] == this.Emoji[0] && Game[2, 0] == this.Emoji[0]) { Console.WriteLine($"Parabéns, o {this.Player[1]} ganhou!!! {this.Emoji[0]} {this.Emoji[0]} {this.Emoji[0]}"); return true; }
            // PLAYER 2
        if (Game[0, 0] == this.Emoji[1] && Game[1, 1] == this.Emoji[1] && Game[2, 2] == this.Emoji[1]) { Console.WriteLine($"Parabéns, o {this.Player[1]} ganhou!!! {this.Emoji[1]} {this.Emoji[1]} {this.Emoji[1]}"); return true; }
        if (Game[0, 2] == this.Emoji[1] && Game[1, 1] == this.Emoji[1] && Game[2, 0] == this.Emoji[1]) { Console.WriteLine($"Parabéns, o {this.Player[1]} ganhou!!! {this.Emoji[1]} {this.Emoji[1]} {this.Emoji[1]}"); return true; }
        
        // DEU VELHA!
        if (rounds == 10 && !WinCondition(ref rounds)) { Console.WriteLine("Deu velha!"); return true; }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // ENTRADA E SAIDA DE EMOJIS NO CONSOLE
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // INSTANCIANDO UM NOVO JOGO
        Tic_Tac_Moji NewGame = new Tic_Tac_Moji();
        // TURNO COMEÇA EM 0 - É TIRADO UM "CARA OU COROA" PRA VER QUEM VAI COMEÇAR
        int turn = 0;
        // RODADAS
        int rounds = 0;

        // MENSAGENS DO COMEÇO DO JOGO
        NewGame.StartGame();

        // CRIAÇÃO DOS PLAYERS - NOME E LETRA/EMOJI
        for (int players = 0; players < 2; players++)
        {
            Console.Write($"Informe o nome do jogador {players + 1}: ".ToUpper());
            NewGame.Player[players] = Console.ReadLine();
            Console.Write("Informe o emoji a ser usado: ".ToUpper());
            NewGame.Emoji[players] = Console.ReadLine();
        }
        // MOSTRA INFORMAÇÕES DOS NOMES / EMOJIS
        NewGame.ShowInformations();
        // ALEATORIZA QUEM VAI COMEÇAR
        NewGame.ChooseTurn(ref turn);
        // INFORMA QUEM VAI COMEÇAR
        NewGame.SlowText($"O jogador que começará vai ser . . . . . . . . . : {NewGame.Player[turn - 1]}".ToUpper(), false);
        // MOSTRA A TELA 3 x 3
        NewGame.ShowGame();

        // JOGO SÓ PARA QUANDO COMPARA AS CONDICOES DE VITORIA
        while (!NewGame.WinCondition(ref rounds))
        {
            NewGame.ChangeTurn(ref turn);
            NewGame.InputKey(ref turn);
            NewGame.ShowGame();
        }
    }
}