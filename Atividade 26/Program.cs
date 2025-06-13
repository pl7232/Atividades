decimal numero1 = 12, numero2 = 30, numero3 = 2.36m;

Console.WriteLine("Digite o primeiro número:");
numero1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numero2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
numero3 = Convert.ToDecimal(Console.ReadLine());

decimal valorfinal = (numero1 * numero2 * numero3);
Console.WriteLine("O valor final é: " + valorfinal);

