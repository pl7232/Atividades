decimal cateto1 = 0, cateto2 = 0;

Console.WriteLine("Digite o valor do cateto 1 do triangulo:");
cateto1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor do cateto 2 do triangulo:");
cateto2 = Convert.ToDecimal(Console.ReadLine());


decimal hipotenusa = (decimal)Math.Sqrt((double)(cateto1 * cateto1 + cateto2 * cateto2));

Console.WriteLine("O valor da hipotenusa é: " + hipotenusa);
