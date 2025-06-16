decimal peso = 0, quilos = 0, gramas = 0;

Console.WriteLine("Digite o peso em quilos:");
quilos = Convert.ToDecimal(Console.ReadLine());


peso = quilos + (gramas / 1000);
Console.WriteLine("O peso em gramas é: " + (peso * 1000));



