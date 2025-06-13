int meiacola = 0, mls = 0, litros = 0;

Console.WriteLine("Digite a quantidade de meias colas que deseja fazer:");
meiacola = Convert.ToInt32(Console.ReadLine());

mls = meiacola * 3;

litros = mls / 1000;
Console.WriteLine("A quantidade de litros de cola necessária para fazer " + meiacola + litros);
