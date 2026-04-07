using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1,100);
            Console.WriteLine("digite um numero inteiro entre 1 e 100");
            int chute = int.Parse(Console.ReadLine());

            while (chute != valorInteiro)
            {
                if (chute < valorInteiro)
                {
                    Console.WriteLine("O número é maior do que o chute.");
                }
                else
                {
                    Console.WriteLine("O número é menor do que o chute.");
                }
                Console.WriteLine("Tente novamente:");
                chute = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Parabéns! Você acertou o número.");

        }
    }
}