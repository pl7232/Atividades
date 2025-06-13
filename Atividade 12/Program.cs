decimal salario = 1500, aumento = 15, novosalario = 0, descontoImposto = 10, amento = 0;

Console.WriteLine("Digite o salário atual: ");
salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o aumento percentual: ");
amento = Convert.ToDecimal(Console.ReadLine());

if (salario > 0 == amento > 0)
{
    novosalario = salario + (salario * amento / 100);
    Console.WriteLine("O novo salário é: " + novosalario);

    decimal imposto = novosalario * descontoImposto / 100;
    Console.WriteLine("O desconto de imposto é: " + imposto);

    decimal salarioFinal = novosalario - imposto / 100;
    Console.WriteLine("O salário final após o desconto de imposto é: " + salarioFinal);

    decimal aumentoValor = salario * amento / 100;
    Console.WriteLine("O valor do aumento é: " + aumentoValor);
}
else
{
    if (salario <= 0 == amento <= 0)
        Console.WriteLine("Salário e aumento devem ser maiores que zero.");
    else if (salario <= 0)
        Console.WriteLine("Salário deve ser maior que zero.");
    else if (amento <= 0)
        Console.WriteLine("Aumento percentual deve ser maior que zero.");
}
