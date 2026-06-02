using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];

            matriz = new int[4, 4] { { 0, 524, 521, 882 },{ 524, 0, 434, 586 },{ 521, 434, 0, 429 },{ 882, 586, 429, 0 } };
            Console.WriteLine("Matriz de distâncias entre as cidades:");
            Console.WriteLine("Programa para saber distancia entra cidades (Vitoria, Belo Horizonte, Rio de Janeiro e São Paulo)");
            Console.WriteLine("Digite a cidade de origem e a cidade de destino:");
            string origem = Console.ReadLine();
            string destino = Console.ReadLine();

            //Vitoria = 1 -- Belo Horizonte = 2 -- Rio de Janeiro = 3 -- São Paulo = 4

            //TRASNFORMANDO AS CIDADES EM NÚMEROS PARA CONSEGUIR ACESSAR A MATRIZ

            int origemNumero = 0;
            int destinoNumero = 0;

            if (origem == "Vitoria" || origem == "vitoria" || origem == "VITORIA") origemNumero = 0;
            
            else if (origem == "Belo Horizonte" || origem == "belo horizonte" || origem == "BELO HORIZONTE") origemNumero = 1;
            else if (origem == "Rio de Janeiro" || origem == "rio de janeiro" || origem == "RIO DE JANEIRO") origemNumero = 2;
            else if (origem == "São Paulo" || origem == "são paulo" || origem == "SÃO PAULO") origemNumero = 3;
            else
            {
                Console.WriteLine("Cidade de origem inválida.");
                return;
            }

            if (destino == "Vitoria" || destino == "vitoria" || destino == "VITORIA") destinoNumero = 0;
            else if (destino == "Belo Horizonte" || destino == "belo horizonte" || destino == "BELO HORIZONTE") destinoNumero = 1;
            else if (destino == "Rio de Janeiro" || destino == "rio de janeiro" || destino == "RIO DE JANEIRO") destinoNumero = 2;
            else if (destino == "São Paulo" || destino == "são paulo" || destino == "SÃO PAULO") destinoNumero = 3;
            else
            {
                Console.WriteLine("Cidade de destino inválida.");
                return;
            }

            Console.WriteLine($"A distância entre {origem} e {destino} é de {matriz[origemNumero, destinoNumero]} km.");

        }
    }
}