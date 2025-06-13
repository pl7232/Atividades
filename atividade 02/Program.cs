
int cavalos = 20;

int ferraduras = 50, quantidadeCavalos = ferraduras;

Console.WriteLine("Digite a quantidade de cavalos: ");
Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de ferraduras: ");
cavalos = Convert.ToInt32(Console.ReadLine());

if (ferraduras > 0 && cavalos > 0)
{
    quantidadeCavalos = ferraduras / 4;
    Console.WriteLine("A quantidade de ferraduras presisa é: " + ferraduras * cavalos);
}
else
{
    if (ferraduras <= 0 && cavalos <= 0)
        Console.WriteLine("Ferraduras e cavalos devem ser maiores que zero.");
    else if (ferraduras <= 0)
        Console.WriteLine("Ferraduras devem ser maiores que zero.");
    else if (cavalos <= 0)
        Console.WriteLine("Cavalos devem ser maiores que zero.");
}
