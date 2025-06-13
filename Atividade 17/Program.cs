int celsius = 0, fahrenheit = 0;

Console.WriteLine("Digite a temperatura em Celsius do país:");
celsius = Convert.ToInt32(Console.ReadLine());

fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine("A temperatura em Fahrenheit do país é: " + fahrenheit);
Console.WriteLine("Pressione qualquer tecla para sair...");

Console.ReadKey();
