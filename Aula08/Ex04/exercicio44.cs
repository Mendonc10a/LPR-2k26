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
            // Os vetores são criados aqui na Main para que os dados não se percam entre as opções do menu
            Heroi[] herois = new Heroi[5];
            Heroi[] equipe = new Heroi[3]; 
            
            int opcao;

            // O loop do-while garante que o programa continue rodando até o usuário digitar 4
            do
            {
                MenuPrincipal();
                Console.Write("Escolha uma opção: ");
                
                // O int.TryParse evita que o programa quebre se o usuário digitar uma letra por engano no menu
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = 0; // Opção inválida
                }

                switch (opcao)
                {
                    case 1:
                        CadastrarHerois(herois);
                        break;
                    case 2:
                        // Passamos o vetor de heróis cadastrados E o vetor onde a equipe será salva
                        SelecionarEquipe(herois, equipe);
                        break;
                    case 3:
                        // Exibe a equipe que foi salva na opção 2
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

        // e) Função MenuPrincipal exigida pelo exercício
        static void MenuPrincipal()
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("    SISTEMA SELEÇÃO MARVEL   ");
            Console.WriteLine("=============================");
            Console.WriteLine("1 - Cadastrar Heróis (Máx 5)");
            Console.WriteLine("2 - Selecionar Equipe (3 Heróis)");
            Console.WriteLine("3 - Exibir Equipe Final");
            Console.WriteLine("4 - Sair do Programa");
            Console.WriteLine("=============================");
        }

        static void CadastrarHerois(Heroi[] herois)
        {
            Console.WriteLine("\n--- CADASTRO DE HERÓIS ---");
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

        // Ajustado para receber o vetor 'equipe' e preencher ele diretamente
        static void SelecionarEquipe(Heroi[] herois, Heroi[] equipe)
        {
            // Validação simples: se o primeiro herói não tem nome, ninguém foi cadastrado ainda
            if (string.IsNullOrEmpty(herois[0].nome))
            {
                Console.WriteLine("\n[ERRO] Cadastre os heróis na opção 1 antes de selecionar a equipe!");
                return;
            }

            Console.WriteLine("\n--- SELEÇÃO DE EQUIPE ---");
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

                // Salva o herói escolhido diretamente no vetor de equipe da Main
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
            // Validação se a equipe já foi escolhida
            if (string.IsNullOrEmpty(equipe[0].nome))
            {
                Console.WriteLine("\n[ERRO] Nenhuma equipe foi selecionada ainda! Vá na opção 2.");
                return;
            }

            Console.WriteLine("\n=== EQUIPE SELECIONADA ===");
            for (int i = 0; i < equipe.Length; i++)
            {
                Console.WriteLine($"- {equipe[i].nome} ({equipe[i].poder}) - Pontuação: {equipe[i].pontuacao}");
            }
            
            // Aqui chamamos a função de cálculo passando o vetor da equipe
            Console.WriteLine($"\nPontuação Total da Equipe: {CalcularPontuacaoTotal(equipe)}");
        }
    }
}