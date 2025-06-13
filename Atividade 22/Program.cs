int moedascofrinho = 0, valor = 0;

int moedas1 = 0, moedas5 = 0, moedas10 = 0, moedas25 = 0, moedas50 = 0;

Console.WriteLine("Digite a quantidade de moedas de 1 centavo:");
moedas1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 5 centavos:");
moedas5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 10 centavos:");
moedas10 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 25 centavos:");
moedas25 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 50 centavos:");
moedas50 = Convert.ToInt32(Console.ReadLine());

moedascofrinho = (moedas1 * 1) + (moedas5 * 5) + (moedas10 * 10) + (moedas25 * 25) + (moedas50 * 50);
valor = moedascofrinho / 100;
Console.WriteLine("O valor total do cofre é: " + valor.ToString("C"));



