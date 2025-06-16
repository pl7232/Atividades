decimal tabuada = 0, numero = 0;

Console.WriteLine("Digite um número para ver a tabuada:");
numero = Convert.ToDecimal(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    tabuada = numero * i;
    Console.WriteLine($"{numero} x {i} = {tabuada}");
}
Console.WriteLine("Tabuada completa!");
Console.WriteLine("Deseja ver a tabuada de outro número? (s/n)");
string resposta = Console.ReadLine().ToLower();

