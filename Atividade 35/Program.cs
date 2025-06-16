int diagonalmaior = 0, diagonalmmenor = 0;

Console.WriteLine("Digite a diagonal maior do losango:");
diagonalmaior = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a diagonal menor do losango:");
diagonalmmenor = Convert.ToInt32(Console.ReadLine());

int area = (diagonalmaior * diagonalmmenor) / 2;

Console.WriteLine("A área do losango é: " + area);

