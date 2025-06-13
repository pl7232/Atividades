int nota1 = 0, nota2 = 2, nota3 = 3, media = nota1 * nota2 * nota3;

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
nota3 = Convert.ToInt32(Console.ReadLine());

if (nota1 >= 0 == nota2 >= 0 == nota3 >= 0)
{
    media = (nota1 + nota2 + nota3) / 3;
    Console.WriteLine("A média das notas é: " + media);
}
else
{
    if (nota1 < 0 && nota2 < 0 && nota3 < 0)
        Console.WriteLine("Todas as notas devem ser maiores ou iguais a zero.");
    else if (nota1 < 0)
        Console.WriteLine("A primeira nota deve ser maior ou igual a zero.");
    else if (nota2 < 0)
        Console.WriteLine("A segunda nota deve ser maior ou igual a zero.");
    else if (nota3 < 0)
        Console.WriteLine("A terceira nota deve ser maior ou igual a zero.");
}
