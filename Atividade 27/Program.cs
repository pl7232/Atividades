int numero1 = 0, numero2 = 0;

Console.WriteLine("Digite o primeiro número:");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numero2 = Convert.ToInt32(Console.ReadLine());

int valorfinal = (numero1 / numero2);

if (valorfinal < 0)
{
    valorfinal = 0;
}

if (valorfinal > 100)
{
    valorfinal = 100;
}
Console.WriteLine("O valor final é: " + valorfinal);



