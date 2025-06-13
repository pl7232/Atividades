decimal suaAltura = 1.73m, sombradopredio = 0, alturapredio = 0;

Console.WriteLine("Digite a altura da sombra em metros do prédio:");
sombradopredio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a sua altura:");
suaAltura  = Convert.ToDecimal(Console.ReadLine());

decimal angulopredio = sombradopredio = suaAltura;
Console.WriteLine("O a altura do predio é: " + sombradopredio * suaAltura / sombradopredio + suaAltura  );

