using System;

namespace CadastroMarvel
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[5];
            string[] poderes = new string[5];
            int[] pontos = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Cadastro do {i + 1}º Herói ");
                cadastrarHeroi(nomes, poderes, pontos, i);
            }

            int[] escolhidos = selecionarEquipe(nomes);

            calcularPontuacaoTotal(pontos, escolhidos);
        }

        static void cadastrarHeroi(string[] n, string[] p, int[] pts, int i)
        {
            Console.Write("Nome: ");
            n[i] = Console.ReadLine();

            Console.Write("Poder: ");
            p[i] = Console.ReadLine();

            Console.Write("Pontuação: ");
            pts[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        static int[] selecionarEquipe(string[] n)
        {
            int[] selecionados = new int[3];
            Console.WriteLine("\n Selecione sua equipe (Escolha 3): ");
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i} - {n[i]}");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Número do {i + 1}º herói: ");
                selecionados[i] = int.Parse(Console.ReadLine());
            }
            return selecionados;
        }
        static void calcularPontuacaoTotal(int[] pts, int[] escolhidos)
        {
            int soma = 0;
            for (int i = 0; i < 3; i++)
            {
                int posicao = escolhidos[i];
                soma = soma + pts[posicao];
            }
            Console.WriteLine("Pontuação Total: " + soma);
        }

        static void exibirEquipe(string[] n, string[] p, int[] pts, int[] escolhidos)
        {
            Console.WriteLine("\nEquipe Selecionada:");
            for (int i = 0; i < 3; i++)
            {
                int posicao = escolhidos[i];
                Console.WriteLine($"Nome: {n[posicao]}, Poder: {p[posicao]}, Pontuação: {pts[posicao]}");
            }
        }

        void menuPrincipal()
        {
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Calcular Pontuação Total");
            Console.WriteLine("4 - Exibir Equipe Selecionada");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    cadastrarHeroi(nomes, poderes, pontos, 0);
                    break;
                case 2:
                    selecionarEquipe(nomes);
                    break;
                case 3:
                    calcularPontuacaoTotal(pontos, selecionados);
                    break;
                case 4:
                    exibirEquipe(nomes, poderes, pontos, selecionados);
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }           

        }
    }
}