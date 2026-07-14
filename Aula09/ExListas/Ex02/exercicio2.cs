using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de nomes (X): ");
        int x = int.Parse(Console.ReadLine());

        List<string> nomes = new List<string>();
        for (int i = 0; i < x; i++)
        {
            Console.Write($"Digite o nome {i + 1}: ");
            nomes.Add(Console.ReadLine());
        }

        Console.WriteLine("Nomes agrupados por tamanho:");

        Dictionary<int, List<string>> grupos = new Dictionary<int, List<string>>();
        foreach (var nome in nomes)
        {
            int tam = nome.Length;
            if (!grupos.ContainsKey(tam)) grupos[tam] = new List<string>();
            grupos[tam].Add(nome);
        }

        int maxLinhas = grupos.Values.Max(g => g.Count);

        for (int i = 0; i < maxLinhas; i++)
        {
            List<string> linha = new List<string>();
            foreach (var tam in grupos.Keys.OrderBy(t => t))
            {
                if (i < grupos[tam].Count)
                {
                    linha.Add(grupos[tam][i]);
                }
            }
            Console.WriteLine(string.Join(" ", linha));
        }
    }
}