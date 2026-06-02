using system;
namespace exercicio4
{
    class Program
    {
        int main(string[] args)
        {
            /*le duas matrizes 3x3*/

            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];

            Console.WriteLine("Digite os elementos da matriz A:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os elementos da matriz B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            matrizMultiplicada = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizMultiplicada[i, j] = matrizA[i, j] * matrizB[i, j];
                }
            }

            Console.WriteLine("Matriz resultante da multiplicação:");

            int z = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"O elemento [{i},{j}] é: {matrizMultiplicada[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}