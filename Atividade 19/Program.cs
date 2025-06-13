decimal chipi = 4m, anel = 3.50m;

decimal total = 0m;
Console.WriteLine("Digite a quantidade de chips:");
int quantidadeChips = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de anéis:");
int quantidadeAnel = Convert.ToInt32(Console.ReadLine());

total = (quantidadeChips * chipi) + (quantidadeAnel * anel);

Console.WriteLine("O valor total da compra é: " + total.ToString("C"));
Console.WriteLine("Pressione qualquer tecla para sair...");

Console.ReadKey();
