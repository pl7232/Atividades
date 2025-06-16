int idade = 0, ano = 0, meses = 0, dias = 0;

Console.WriteLine("Digite usa idade ");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o ano atual ");
ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite os meses atuais ");
meses = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite os dias atuais ");
dias = Convert.ToInt32(Console.ReadLine());

int idadeEmDias = (idade * 365) + (ano * 365) + (meses * 30) + dias;
Console.WriteLine("A idade em dias é: " + idadeEmDias);
Console.WriteLine("A idade em anos é: " + (idadeEmDias / 365));

Console.WriteLine("A idade em meses é: " + (idadeEmDias / 30));
Console.WriteLine("A idade em semanas é: " + (idadeEmDias / 7));