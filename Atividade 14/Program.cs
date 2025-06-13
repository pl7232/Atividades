decimal pizza = 3.14m, raio = 0, area = 0;

Console.WriteLine("Digite o raio da pizza: ");
raio = Convert.ToDecimal(Console.ReadLine());

if (raio > 0)
{
    area = pizza * raio * raio;
    Console.WriteLine("A área da pizza é: " + area * pizza);
}
else
{
    if (raio <= 0)
        Console.WriteLine("O raio deve ser maior que zero.");
}
