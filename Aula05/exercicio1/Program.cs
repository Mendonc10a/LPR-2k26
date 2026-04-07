Console.Write("Digite a quantidade de números: ");
int totalParaDigitar = int.Parse(Console.ReadLine());

double somaPares = 0;
int contadorPares = 0;
int i = 1;

while (i <= totalParaDigitar)
{
    Console.Write($"Digite o {i}º número: ");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        somaPares += num;
        contadorPares++;
    }
    i++; 
}

if (contadorPares > 0)
{
    Console.WriteLine($"\nMédia dos pares: {somaPares / contadorPares}");
}
else
{
    Console.WriteLine("\nNenhum par digitado.");
}