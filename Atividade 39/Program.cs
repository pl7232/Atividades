decimal salario = 1200, conta1 = 200, conta2 = 120;

Console.WriteLine("Digite o salário do funcionário:");
salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor da conta 1:");
conta1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor da conta 2:");
conta2 = Convert.ToDecimal(Console.ReadLine());

decimal valorfinal = salario - (conta1 + conta2) ;
Console.WriteLine("O valor final é: " + valorfinal);