int[,] matriz = new int[5, 5];
int valor = 1;

// preenchendo de 1 a 25
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matriz[i, j] = valor++;
    }
}

Console.WriteLine("Diagonal principal:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(matriz[i, i]);
}

Console.WriteLine("Diagonal secundária:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(matriz[i, 4 - i]);
}
