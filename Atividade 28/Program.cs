decimal nota1 = 0, nota2 = 0;

Console.WriteLine("Digite a primeira nota:");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
nota2 = Convert.ToDecimal(Console.ReadLine());

decimal media = (nota1 + nota2) / 5;
if (media > 10)
{
    media = 10;
}
if (nota1 > 2)
{
    nota2 = 3;
}
Console.WriteLine("A média é: " + media + nota1 + nota2 / 2);
