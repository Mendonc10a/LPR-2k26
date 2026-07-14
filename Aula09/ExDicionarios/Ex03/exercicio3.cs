using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, int> citys = new Dictionary<string, int>();
        Console.WriteLine("Quantas cidades deseja cadastrar?");
        int quantity = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantity; i++)
        {
            Console.WriteLine($"Digite o nome da cidade {i + 1}:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Digite a população da cidade {nome}:");
            int populacao = int.Parse(Console.ReadLine());
            citys[nome] = populacao;
        }

        int totalPopulacao = 0;
        foreach (var cidade in citys)
        {
            totalPopulacao += cidade.Value;
        }
        double media = (double)totalPopulacao / quantity;
        Console.WriteLine($"A média da população das cidades é: {media}");

        string cityH = null;
        int populationHigher = 0;

        for (int y =0; y <quantity; y++)
        {
            if (citys.Values[y] > populationHigher)
            {
                populationHigher = citys.Values[y];
                cityH = citys.Keys[y];
            }
        }
        Console.WriteLine($"A cidade com maior população é: {cityH} com população de: {populationHigher}");

        string cityL = null;
        int populationLower = int.MaxValue;

        for (int y = 0; y < quantity; y++)
        {
            if (citys.Values[y] < populationLower)
            {
                populationLower = citys.Values[y];
                cityL = citys.Keys[y];
            }
        }
        Console.WriteLine($"A cidade com menor população é: {cityL} com população de: {populationLower}");
        Console.WriteLine("Escolha um valor para remover cidades com determiadas populacoes");
        int removeValue = int.Parse(Console.ReadLine());

        for (int z = 0; z < quantity; z++)
        {
            if (citys.Values[z] == removeValue)
            {
                citys.Remove(citys.Keys[z]);
            }
        }
        Console.WriteLine("Cidades restantes após a remoção:");
        foreach (var cidade in citys)
        {   
            Console.WriteLine($"Cidade: {cidade.Key}, População: {cidade.Value}");
        }
    }
}
