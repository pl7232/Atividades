int salario = 0, horasextras = 0, salariofinal = 0, salariodesconto = 0, salarioliquido = 0;

Console.WriteLine("Digite o salário do funcionário:");
salario = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o número de horas extras trabalhadas:");
horasextras = Convert.ToInt32(Console.ReadLine());

salariofinal = salario + (horasextras * 5);

Console.WriteLine("O salário final do funcionário é: " + salariofinal);
Console.WriteLine("Digite o valor do desconto do salário:");
salariodesconto = Convert.ToInt32(Console.ReadLine());
salarioliquido = salariofinal - salariodesconto;
Console.WriteLine("O salário líquido do funcionário é: " + salarioliquido);


