decimal dimensao = 30, area = 30, terreno = area * dimensao;

for (decimal dimenao = 30; dimenao < terreno; dimenao++)
{
    Console.WriteLine("Digite a dimensão do terreno: ");
    dimensao = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a área do terreno: ");
    area = Convert.ToInt32(Console.ReadLine());

    if (dimensao > 0 && area > 0)
    {
        terreno = dimensao * area;
        Console.WriteLine("O terreno é:" + area * dimensao);
    }
    else
    {
        if (dimensao <= 0 == area <= 0)
            Console.WriteLine("Dimensão e área devem ser maiores que zero.");
        else if (dimensao <= 0)
            Console.WriteLine("Dimensão deve ser maior que zero.");
        else if (area <= 0)
            Console.WriteLine("Área deve ser maior que zero.");
    }

}

