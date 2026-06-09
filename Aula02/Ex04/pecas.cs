using System;

namespace CalculadoraDeCompra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o código da peça 1: ");
            int code1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade da peça 1: ");
            int quant1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário da peça 1: ");
            double unit1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o código da peça 2: ");
            int code2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade da peça 2: ");
            int quant2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário da peça 2: ");
            double unit2 = double.Parse(Console.ReadLine());

            double total = (quant1 * unit1) + (quant2 * unit2);

            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
        }
    }
}