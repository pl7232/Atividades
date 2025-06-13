decimal kilo = 12;

decimal preco = kilo, total = 0;

Console.WriteLine("Digite a quantidade de refeições: ");
kilo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite quantos quilos tem a refeição: ");
preco = Convert.ToDecimal(Console.ReadLine());

if (kilo > 0 && preco > 0)
{
    total = kilo * preco;
    Console.WriteLine("O total a pagar é: " + total);
}
else
{
    if (kilo <= 0 && preco <= 0)
        Console.WriteLine("Quantidade e preço devem ser maiores que zero.");
    else if (preco <= 0)
        Console.WriteLine("Quantidade deve ser maior que zero.");
    else if (preco <= 0)
        Console.WriteLine("Preço deve ser maior que zero.");
}


