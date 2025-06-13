decimal partetonel = 8, parteagua = 2;

Console.WriteLine("Digite a quantidade de partes de suco que deseja fazer:");
decimal partesagua = Convert.ToDecimal(Console.ReadLine());

decimal totalTonel = partesagua + partetonel;

Console.WriteLine("os litros presisos para o suco são: " + totalTonel + parteagua  );

