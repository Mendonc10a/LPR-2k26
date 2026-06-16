using System;
namespace exercicio1;

struct Filme
{
    string titulo;
    string diretor;
    string anoLancamento;
    string duracaoMin;
};

int main(string[] args)
{
    Filme[] lista = new Filme[3];

    Console.WriteLine("Digite os detalhes dos filmes:");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Filme {i + 1}:");
        Console.WriteLine("Título:");
        lista[i].titulo = Console.ReadLine();
        Console.WriteLine("Diretor:");
        lista[i].diretor = Console.ReadLine();
        Console.WriteLine("Ano de Lançamento:");
        lista[i].anoLancamento = Console.ReadLine();
        Console.WriteLine("Duração (minutos):");
        lista[i].duracaoMin = Console.ReadLine();
    }

    Console.WriteLine("\nFilmes Cadastrados:");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Filme {i + 1}:");
        Console.WriteLine($"Título: {lista[i].titulo}");
        Console.WriteLine($"Diretor: {lista[i].diretor}");
        Console.WriteLine($"Ano de Lançamento: {lista[i].anoLancamento}");
        Console.WriteLine($"Duração: {lista[i].duracaoMin} minutos");
        Console.WriteLine();
    }

    Filme filmeMaisLongo = lista[0];
    for (int i = 1; i < 3; i++)
    {
        if (int.Parse(lista[i].duracaoMin) > int.Parse(filmeMaisLongo.duracaoMin))
        {
            filmeMaisLongo = lista[i];
        }
    }

    Console.WriteLine("Filme mais longo:");
    Console.WriteLine($"Título: {filmeMaisLongo.titulo}");

    return 0;
}