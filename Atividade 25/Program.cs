int caixadeaguaCilindrica = 0, volume = 0;

Console.WriteLine("Digite o raio da caixa d'água cilíndrica (em metros):");
int raio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a altura da caixa d'água cilíndrica (em metros):");
int altura = Convert.ToInt32(Console.ReadLine());

// Fórmula do volume de um cilindro: V = π * r² * h

volume = (int)(Math.PI * Math.Pow(raio, 2) * altura);
Console.WriteLine("O volume da caixa d'água cilíndrica é: " + volume + " metros cúbicos.");
