using System;
namespace exercicio3;

struct Livro
{
    string titulo;
    string autor;
    string anoP;
    int numPaginas;
    double preco;
};
int main (string[] args)
{

    Livro[] biblioteca = new Livro[3];
    Console.WriteLine("Digite os detalhes dos livros:");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Livro {i + 1}:");
        Console.WriteLine("Título:");
        biblioteca[i].titulo = Console.ReadLine();
        Console.WriteLine("Autor:");
        biblioteca[i].autor = Console.ReadLine();
        Console.WriteLine("Ano de Publicação:");
        biblioteca[i].anoP = Console.ReadLine();
        Console.WriteLine("Número de Páginas:");
        biblioteca[i].numPaginas = int.Parse(Console.ReadLine());
        Console.WriteLine("Preço:");
        biblioteca[i].preco = double.Parse(Console.ReadLine());
    }

    Console.WriteLine("'\nPreço dos Livros Cadastrados e A media de paginas:");
    double precoTotal = 0;
    int totalPaginas = 0;
    for (int i = 0; i < 3; i++)
    {
        precoTotal += biblioteca[i].preco;
        totalPaginas += biblioteca[i].numPaginas;
    }
    Console.WriteLine($"R${precoTotal:F2}");
    Console.WriteLine($"Média de páginas: {totalPaginas / 3.0:F2}");

    return 0;
}