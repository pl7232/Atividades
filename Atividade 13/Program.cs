decimal numero = 321, centenas = 0, dezenas = 0, unidades = 0;

Console.WriteLine("Digite um número de 3 dígitos: ");
numero = Convert.ToDecimal(Console.ReadLine());

if (numero >= 100 && numero <= 999)
{
    centenas = numero / 100;
    dezenas = (numero % 100) / 10;
    unidades = (numero % 100) % 10;

    Console.WriteLine("Centenas: " + centenas);
    Console.WriteLine("Dezenas: " + dezenas);
    Console.WriteLine("Unidades: " + unidades);
}
else
{
    Console.WriteLine("O número deve ser um inteiro de 3 dígitos.");
}
