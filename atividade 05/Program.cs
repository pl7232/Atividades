int litrosGasolina = 5, precoGasolina = 6, total = 0;

Console.WriteLine("Digite a quantidade de litros de gasolina: ");
litrosGasolina = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor que deseja colocar: ");
precoGasolina = Convert.ToInt32(Console.ReadLine());

total = litrosGasolina * precoGasolina;

if (litrosGasolina > 0 && precoGasolina > 0)
{
    total = litrosGasolina * precoGasolina;
    Console.WriteLine("O total de litros é: " + total);
}
else
{
    if (litrosGasolina <= 0 && precoGasolina <= 0)
        Console.WriteLine("Litros de gasolina e preço devem ser maiores que zero.");
    else if (litrosGasolina <= 0)
        Console.WriteLine("Litros de gasolina devem ser maiores que zero.");
    else if (precoGasolina <= 0)
        Console.WriteLine("Preço da gasolina deve ser maior que zero.");
}