string[] nomes = new string[10];
double[,] notas = new double[10, 3];
double[] medias = new double[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();

    double soma = 0;
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Nota {j + 1}: ");
        notas[i, j] = double.Parse(Console.ReadLine());
        soma += notas[i, j];
    }

    medias[i] = soma / 3;
}

Console.WriteLine("\nRelatório:");
for (int i = 0; i < 10; i++)
{
    if (medias[i] >= 7)
        Console.ForegroundColor = ConsoleColor.Blue;
    else
        Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine($"{nomes[i]} - Média: {medias[i]:F2}");
}

Console.ResetColor();
