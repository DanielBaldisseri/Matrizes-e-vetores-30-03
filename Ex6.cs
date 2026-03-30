char[,] jogo = new char[3, 3];
char jogador = 'X';

for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        jogo[i, j] = ' ';

for (int rodada = 0; rodada < 9; rodada++)
{
    Console.Clear();

    // mostrar tabuleiro
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"{jogo[i,0]} | {jogo[i,1]} | {jogo[i,2]}");
        if (i < 2) Console.WriteLine("--+---+--");
    }

    Console.WriteLine($"Jogador {jogador}");
    Console.Write("Linha (0-2): ");
    int l = int.Parse(Console.ReadLine());

    Console.Write("Coluna (0-2): ");
    int c = int.Parse(Console.ReadLine());

    if (jogo[l, c] == ' ')
    {
        jogo[l, c] = jogador;
        jogador = (jogador == 'X') ? 'O' : 'X';
    }
    else
    {
        Console.WriteLine("Posição ocupada!");
        rodada--;
        Console.ReadKey();
    }
}
