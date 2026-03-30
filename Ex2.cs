string[] nomes = new string[10];
double[] precos = new double[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Nome do produto: ");
    nomes[i] = Console.ReadLine();

    Console.Write("Preço: ");
    precos[i] = double.Parse(Console.ReadLine());
}

Console.Write("Digite um valor para busca: ");
double valor = double.Parse(Console.ReadLine());

Console.WriteLine("Produtos com preço maior ou igual:");
for (int i = 0; i < 10; i++)
{
    if (precos[i] >= valor)
        Console.WriteLine($"{nomes[i]} - R$ {precos[i]}");
}
