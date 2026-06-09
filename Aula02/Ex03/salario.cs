using System; 

namespace MeuProjeto 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.Write("Digite o número do funcionário: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Digite as horas trabalhadas: ");
        int horas = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor por hora: ");
        double valor = double.Parse(Console.ReadLine());

        float salary = valor * horas;

        Console.WriteLine ($"O numero do funciorio eh: {number}\n e o salario deste mesmo funcionario eh de: {salary:F2}");
        }
    }
}
