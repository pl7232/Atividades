decimal sanduiches = 0,sanduichedeQueijo = 0, sanduichedePresunto = 0, fatiasdeQueijo = 2, Hamburguer = 100, kilo = 0, gramas = 0;

Console.WriteLine("Digite a quantidade de Sanduiches: ");
sanduiches = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de Sanduiches de Queijo: ");
sanduichedeQueijo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de Sanduiches de Presunto: ");
sanduichedePresunto = Convert.ToDecimal(Console.ReadLine());


if (sanduiches > 0 && sanduichedeQueijo >= 0 && sanduichedePresunto >= 0)
{
    sanduiches = sanduichedeQueijo + sanduichedePresunto;
    kilo = (sanduichedeQueijo * fatiasdeQueijo + sanduichedePresunto * Hamburguer) / 1000;
    gramas = kilo * 1000;
    Console.WriteLine("O total de quilos é: " + kilo);
    Console.WriteLine("O total de gramas é: " + gramas);
    Console.WriteLine("O total de Sanduiches é: " + sanduiches);
}
else
{
    if (sanduiches <= 0)
        Console.WriteLine("Quantidade de Sanduiches deve ser maior que zero.");
    else if (sanduichedeQueijo < 0)
        Console.WriteLine("Quantidade de Sanduiches de Queijo não pode ser negativa.");
    else if (sanduichedePresunto < 0)
        Console.WriteLine("Quantidade de Sanduiches de Presunto não pode ser negativa.");
}
