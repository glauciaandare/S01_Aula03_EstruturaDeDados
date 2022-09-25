/*
 * Escreva um programa para determinar se um valor inteiro fornecido pelo usuário é
ou não primo
*/
namespace Exer3j {
    internal class Program {
        static void Main(string[] args)
        {
            int resultado = 0;

            Console.WriteLine("Informe um número");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    resultado++;

                }
            }
            if (resultado == 0)
            {
                Console.WriteLine($"{numero} é primo");
            }
            else
            {
                Console.WriteLine($"{numero} não é primo");
            }
        }

    }
}