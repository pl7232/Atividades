int diasSemacidente = 43000, mesesSemacidente = 0, anosSemacidente = 0;

Console.WriteLine("Digite o número de dias sem acidente: ");
diasSemacidente = Convert.ToInt32(Console.ReadLine());

if (diasSemacidente > 0)
{
    anosSemacidente = diasSemacidente / 365;
    mesesSemacidente = (diasSemacidente % 365) / 30;
    diasSemacidente = (diasSemacidente % 365) % 30;

    Console.WriteLine("O total de dias sem acidente é: " + anosSemacidente + " anos, " + mesesSemacidente + " meses e " + diasSemacidente + " dias.");
}
else
{
    Console.WriteLine("O número de dias sem acidente deve ser maior que zero.");
}
