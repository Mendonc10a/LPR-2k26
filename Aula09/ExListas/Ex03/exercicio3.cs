using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        Random gerador = new Random();

        for (int i = 0; i < 100; i++)
        {
            numeros.Add(gerador.Next(1, 101));
        }

        numeros.Sort();

        Console.WriteLine("--- LISTA ORDENADA CRESCENTE ---");
        foreach (int num in numeros) Console.Write(num + " ");
        Console.WriteLine("\n\n");

        Console.WriteLine("--- NÚMEROS QUE SE REPETEM ---");
        for (int i = 0; i < numeros.Count - 1; i++)
        {

            if (numeros[i] == numeros[i + 1])
            {
                Console.Write(numeros[i] + " ");
                
                while (i < numeros.Count - 1 && numeros[i] == numeros[i + 1])
                {
                    i++;
                }
            }
        }
        Console.WriteLine("\n\n");

        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            if (numeros[i] % 2 == 0)
            {
                numeros.RemoveAt(i);
            }
        }

        Console.WriteLine("Ímpares:");
        foreach (int num in numeros) Console.Write(num + " ");
        Console.WriteLine();
    }
}