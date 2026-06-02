


using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];
            int countPares = 0, countImpares = 0;

            Console.WriteLine("Digite 10 números inteiros:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    pares[countPares++] = numeros[i];
                }
                else
                {
                    impares[countImpares++] = numeros[i];
                }
            }

            Console.WriteLine("\nNúmeros pares:");
            for (int i = 0; i < countPares; i++)
            {
                Console.Write(pares[i] + " ");
            }

            Console.WriteLine("\n\nNúmeros ímpares:");
            for (int i = 0; i < countImpares; i++)
            {
                Console.Write(impares[i] + " ");
            }
        }
    }
}