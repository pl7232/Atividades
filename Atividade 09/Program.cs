int camisetaspequena = 10, camisetaMedia = 12, camisetaGrande = 15, totalCamisetas = 0, valortotal = 0;

Console.WriteLine("Digite a quantidade de camisetas pequenas: ");
camisetaspequena = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de camisetas médias: ");
camisetaMedia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de camisetas grandes: ");
camisetaGrande = Convert.ToInt32(Console.ReadLine());

if (camisetaspequena > 0 && camisetaMedia > 0 && camisetaGrande > 0)
{
    totalCamisetas = camisetaspequena + camisetaMedia + camisetaGrande;
    valortotal = (camisetaspequena * 10) + (camisetaMedia * 12) + (camisetaGrande * 15);
    Console.WriteLine("O total de camisetas é: " + totalCamisetas);
    Console.WriteLine("O valor total é: " + valortotal);
}
else
{
    if (camisetaspequena <= 0 && camisetaMedia <= 0 && camisetaGrande <= 0)
        Console.WriteLine("As quantidades de camisetas devem ser maiores que zero.");
    else if (camisetaspequena <= 0)
        Console.WriteLine("A quantidade de camisetas pequenas deve ser maior que zero.");
    else if (camisetaMedia <= 0)
        Console.WriteLine("A quantidade de camisetas médias deve ser maior que zero.");
    else if (camisetaGrande <= 0)
        Console.WriteLine("A quantidade de camisetas grandes deve ser maior que zero.");
}

