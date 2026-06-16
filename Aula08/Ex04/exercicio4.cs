using System;

namespace exercicio4
{
    // Ajuste: Adicionado 'public' para permitir o acesso aos campos
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
            CadastrarHerois(herois);
            SelecionarEquipe(herois);
            int pontuacaoTotal = CalcularPontuacaoTotal(herois);
            ExibirEquipeFinal(herois);

        }

        static void CadastrarHerois(Heroi[] herois)
        {
            Console.WriteLine("\nCadastre os Herois da Marvel:");
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
        }


        static void SelecionarEquipe(Heroi[] herois)
        {
            Console.WriteLine("\nSelecione Sua Equipe da Marvel (3 heróis):");
            
            //lista de heróis disponíveis
            Console.WriteLine("Heróis disponíveis:");
            for (int i = 0; i < herois.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {herois[i].nome} (Poder: {herois[i].poder} | Pontos: {herois[i].pontuacao})");
            }

            //guardar os 3 heróis escolhidos
            Heroi[] equipe = new Heroi[3];

            //selecionar os 3 heróis
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nEscolha o {i + 1}º herói da sua equipe (digite o número de 1 a 5): ");
                int escolha = int.Parse(Console.ReadLine());

                int indiceOriginal = escolha - 1;

                // Salva o herói 
                equipe[i] = herois[indiceOriginal];
            }
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
            Console.WriteLine("\nEquipe Selecionada:");
            for (int i = 0; i < equipe.Length; i++)
            {
                Console.WriteLine($"- {equipe[i].nome} ({equipe[i].poder}) - Pontuação: {equipe[i].pontuacao}");
            }
            Console.WriteLine($"\nPontuação Total da Equipe: {CalcularPontuacaoTotal(equipe)}");
        }

        static void Menu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Cadastrar Heróis");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe Final");
            Console.WriteLine("4 - Sair");
        }

    }
}