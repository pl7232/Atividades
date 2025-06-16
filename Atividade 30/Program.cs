decimal salariofixo= 0, comissao = 0, vendas = 0;

Console.WriteLine("Digite o salário fixo do vendedor:");
salariofixo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor das vendas do vendedor:");
vendas = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor da comissão do vendedor:");
comissao = Convert.ToDecimal(Console.ReadLine());

decimal valorfinal = (vendas * comissao / 100) + salariofixo;
Console.WriteLine("O valor final a receber do vendedor é: " + valorfinal);

Console.WriteLine("O valor do salário fixo é: " + salariofixo);
Console.WriteLine("O valor da comissão é: " + (vendas * comissao / 100));

Console.WriteLine("O valor total das vendas é: " + vendas);
Console.WriteLine("O valor total a receber do vendedor é: " + (vendas * comissao / 100) + salariofixo);
Console.WriteLine("O valor total a receber do vendedor é: " + valorfinal);
