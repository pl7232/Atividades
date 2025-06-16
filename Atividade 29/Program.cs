decimal produto = 0, preco = 0;

Console.WriteLine("Digite o valor do produto:");
produto = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço do produto:");
preco = Convert.ToDecimal(Console.ReadLine());

decimal valorfinal = (produto * preco / 10);

if (valorfinal < 0)
{
    valorfinal = 0;
}
if (valorfinal > 10)
{
    valorfinal = 10;
}

Console.WriteLine("O valor final é: " + valorfinal);
Console.WriteLine("O valor do produto com desconto é: " + (produto - valorfinal));
