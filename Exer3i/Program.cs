/*
 * O fatorial de um número inteiro positivo é o produto dele por todos os seus
antecessores até 1, representa-se N!. Por definição o fatorial de 0! = 1 e o fatorial
de 1! = 1!. Exemplo: 5! = 5 * 4 * 3 * 2 * 1 = 120. Faça um programa que peça um
número ao usuário e imprima o fatorial deste número na tela.
 */

namespace Exer3i {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Cálculo de Fatorial********** \n ");
            Console.WriteLine("Informe um numero positivo: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double fatorial = numero;
            for(double i = numero - 1; i >= 1; i--)
            {
               fatorial = fatorial * i;

            }

            
            Console.WriteLine("O fatorial do numero " + numero + " é " + fatorial);
        }
    }
}