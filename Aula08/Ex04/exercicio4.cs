using System;

namespace exercicio4
{
    struct Heroi
    {
        public string nome;
        public string poder;
        public int pontuacao;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Heroi[] herois = new Heroi[5];
            Heroi[] equipe = new Heroi[3]; 
            
            int opcao;

            do
            {
                MenuPrincipal();
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        CadastrarHerois(herois);
                        break;
                    case 2:
                        SelecionarEquipe(herois, equipe);
                        break;
                    case 3:
                        ExibirEquipeFinal(equipe);
                        break;
                    case 4:
                        Console.WriteLine("\nSaindo do programa... Até logo!");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        break;
                }

            } while (opcao != 4);
        }

        static void MenuPrincipal()
        {
            Console.WriteLine("    SISTEMA SELEÇÃO MARVEL   ");
            Console.WriteLine("1 - Cadastrar Heróis (Máx 5)");
            Console.WriteLine("2 - Selecionar Equipe (3 Heróis)");
            Console.WriteLine("3 - Exibir Equipe Final");
            Console.WriteLine("4 - Sair do Programa");
        }

        static void CadastrarHerois(Heroi[] herois)
        {
            Console.WriteLine("\nCadastro de Heróis (Máx 5)");
            for (int i = 0; i < herois.Length; i++)
            {
                Console.WriteLine($"\nHerói {i + 1}:");
                Console.Write("Nome: ");
                herois[i].nome = Console.ReadLine();
                Console.Write("Poder: ");
                herois[i].poder = Console.ReadLine();
                Console.Write("Pontuação: ");
                herois[i].pontuacao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nTodos os 5 heróis foram cadastrados com sucesso!");
        }

        static void SelecionarEquipe(Heroi[] herois, Heroi[] equipe)
        {
            if (string.IsNullOrEmpty(herois[0].nome))
            {
                Console.WriteLine("\nCadastre os heróis na opção 1 antes de selecionar a equipe!");
                return;
            }

            Console.WriteLine("Heróis disponíveis:");
            for (int i = 0; i < herois.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {herois[i].nome} (Poder: {herois[i].poder} | Pontos: {herois[i].pontuacao})");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nEscolha o {i + 1}º herói da sua equipe (digite o número de 1 a 5): ");
                int escolha = int.Parse(Console.ReadLine());

                int indiceOriginal = escolha - 1;

                equipe[i] = herois[indiceOriginal];
            }
            Console.WriteLine("\nEquipe selecionada com sucesso! Escolha a opção 3 para ver o resultado.");
        }

        static int CalcularPontuacaoTotal(Heroi[] equipe)
        {
            int pontuacaoTotal = 0;
            for (int i = 0; i < equipe.Length; i++)
            {
                pontuacaoTotal += equipe[i].pontuacao;
            }
            return pontuacaoTotal;
        }

        static void ExibirEquipeFinal(Heroi[] equipe)
        {

            if (string.IsNullOrEmpty(equipe[0].nome))
            {
                Console.WriteLine("\nNenhuma equipe foi selecionada ainda! Vá na opção 2.");
                return;
            }

            Console.WriteLine("\nEQUIPE SELECIONADA");
            for (int i = 0; i < equipe.Length; i++)
            {
                Console.WriteLine($"- {equipe[i].nome} ({equipe[i].poder}) - Pontuação: {equipe[i].pontuacao}");
            }

            Console.WriteLine($"\nPontuação Total da Equipe: {CalcularPontuacaoTotal(equipe)}");
        }
    }
}