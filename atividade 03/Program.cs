decimal pao = 20, preco = 0.12m, broa = 1.50m, total = pao * broa;

Console.WriteLine("Digite a quantidade de pão: ");
pao = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de broa: ");
broa = Convert.ToDecimal(Console.ReadLine());

if (pao > 0 == preco > 0)
{
    total = pao * preco;
    Console.WriteLine("O quanto você arrecadou foi: " + total);
}
else
{
    if (pao <= 0 && preco <= 0)
        Console.WriteLine("Quantidade de pãos e preço devem ser maiores que zero.");
    else if (pao <= 0)
        Console.WriteLine("Quantidade de pão deve ser maior que zero.");
    else if (preco <= 0)
        Console.WriteLine("Preço do pão deve ser maior que zero.");
}