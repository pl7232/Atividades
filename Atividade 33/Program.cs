int Base = 0, altura = 0, Basemenor = 0;
int area = (Base + Basemenor) / 2 * altura;

Console.WriteLine("Digite a Base menor do trapézio:");
area = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a base maior do trapézio:");
Base = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a altura do trapézio:");
altura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A área do trapézio é: " + area);

