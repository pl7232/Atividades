int valordaConta = 500, valorCarlos = 0, valorAndre = 0, valorFelipe = 0, valorTotal = valorAndre + valorCarlos + valorFelipe / 3;


Console.WriteLine("Digite o valor da conta: ");
valordaConta = Convert.ToInt32(Console.ReadLine());

valorTotal = valordaConta;
if (valordaConta > 0)
{
    valorCarlos = valordaConta / 3;
    valorAndre = valordaConta / 3;
    valorFelipe = valordaConta / 3;

    Console.WriteLine("O valor que Carlos irá pagar é: " + valorCarlos);
    Console.WriteLine("O valor que André irá pagar é: " + valorAndre);
    Console.WriteLine("O valor que Felipe irá pagar é: " + valorFelipe);
}
else
{
    Console.WriteLine("O valor da conta deve ser maior que zero.");
}
