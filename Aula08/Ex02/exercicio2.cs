using System;
namespace exercicio2;

struct Produto
{
    string nome;
    string codigo;
    double preco;
    int quantidade;
};

int main(string[] args)
{
    Produto[] estoque = new Produto[3];

    Console.WriteLine("Digite os detalhes dos produtos:");  
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Produto {i + 1}:");
        Console.WriteLine("Nome:");
        estoque[i].nome = Console.ReadLine();
        Console.WriteLine("Código:");
        estoque[i].codigo = Console.ReadLine();
        Console.WriteLine("Preço:");
        estoque[i].preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantidade em Estoque:");
        estoque[i].quantidade = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("\nProdutos Cadastrados:");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Produto {i + 1}:");
        Console.WriteLine($"Nome: {estoque[i].nome}");
        Console.WriteLine($"Código: {estoque[i].codigo}");
        Console.WriteLine($"Preço: R${estoque[i].preco:F2}");
        Console.WriteLine($"Quantidade em Estoque: {estoque[i].quantidade}");
        Console.WriteLine();
    }

    Console.WriteLine("Quantidade total de produtos em estoque:");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Produto {i + 1}: {estoque[i].quantidade} unidades");
    }

    Console.WriteLine("\nValor total em estoque:");
    double valorTotal = 0;
    for (int i = 0; i < 3; i++)
    {
        valorTotal += estoque[i].preco * estoque[i].quantidade;
    }
    Console.WriteLine($"R${valorTotal:F2}");

    return 0;
}

