int idadeMaria = 20, ano = 365;

Console.WriteLine("Digite a idade de Maria: ");
idadeMaria = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o número de dias no ano: ");
ano = Convert.ToInt32(Console.ReadLine());

if (idadeMaria > 0 && ano > 0)
{
    int diasVividos = idadeMaria * ano;
    Console.WriteLine("Maria já viveu " + diasVividos + " dias.");
}
else
{
    if (idadeMaria <= 0 && ano <= 0)
        Console.WriteLine("Idade e número de dias no ano devem ser maiores que zero.");
    else if (idadeMaria <= 0)
        Console.WriteLine("Idade deve ser maior que zero.");
    else if (ano <= 0)
        Console.WriteLine("Número de dias no ano deve ser maior que zero.");
}
