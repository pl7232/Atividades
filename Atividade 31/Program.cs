decimal peso = 0;

Console.WriteLine("Digite o peso:");
peso = Convert.ToDecimal(Console.ReadLine());
decimal engordar = 15;

for (int i = 0; i < 3; i++)
{
    peso += engordar / 15;
}
Console.WriteLine("O peso é: " + engordar );

decimal novopeso = peso + engordar / 20;

Console.WriteLine("O novo peso é: " + novopeso + "peso");
