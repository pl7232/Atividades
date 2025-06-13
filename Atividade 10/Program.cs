decimal pontox = 0, pontoy = 0, distancia = 0;

Console.WriteLine("Digite a coordenada X do ponto: ");
pontox = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a coordenada Y do ponto: ");
pontoy = Convert.ToDecimal(Console.ReadLine());

if (pontox > 0 == pontoy > 0)
{
    Console.WriteLine("A distância do ponto até a origem é: " + pontox * pontoy);
}
else
{
    if (pontox <= 0 == pontoy <= 0)
        Console.WriteLine("As coordenadas X e Y devem ser maiores que zero.");
    else if (pontox <= 0)
        Console.WriteLine("A coordenada X deve ser maior que zero.");
    else if (pontoy <= 0)
        Console.WriteLine("A coordenada Y deve ser maior que zero.");
}