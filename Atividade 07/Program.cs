int mes = 30, ano = 365, dias = mes;

Console.WriteLine("Digite quantos meses: ");
mes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite quantos anos: ");
ano = Convert.ToInt32(Console.ReadLine());

if (mes > 30 == ano > 365)
{
    dias = mes + ano;
    Console.WriteLine("O total de dias é: " + dias + mes + ano);
}
else
{
    if (mes <= 0 == ano <= 0)
        Console.WriteLine("Número de dias no mês e no ano devem ser maiores que zero.");
    else if (mes <= 0)
        Console.WriteLine("Número de dias no mês deve ser maior que zero.");
    else if (ano <= 0)
        Console.WriteLine("Número de dias no ano deve ser maior que zero.");
}



