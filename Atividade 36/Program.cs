decimal salariominimo = 15, salario = 20;

Console.WriteLine("Digite o salário mínimo:");
salariominimo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o salário do funcionário:");
salario = Convert.ToInt32(Console.ReadLine());

decimal valorfinal = (salario * salariominimo) / 2;
if (valorfinal < 0)
{
    valorfinal = 0;
}
if (valorfinal > 100)
{
    valorfinal = 100;
}

Console.WriteLine("O valor final é: " + valorfinal);
Console.WriteLine("A quantidade de salario mínimo é: " + salariominimo );


