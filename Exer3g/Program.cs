/*
 * A tabuada de um determinado número é uma tabela de produtos deste número
com os números de 1 a 9. Escreva um programa que peça um número ao usuário e
imprima a tabuada deste número na tela. Caso o valor dado seja inválido o programa
deve apenas exibir uma mensagem de aviso. Escreva um programa usando cada
estrutura de repetição estudada.
*/

using System;
namespace Exer3g {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("******Tabuada******");
            Console.WriteLine("Digite um número de 1 a 10");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tabuada de " + numero);

            for (int i = 0; i < 11; i++)
            {
                
                int resultado = numero * i;
                
                Console.WriteLine(numero + " x " + i + " =" + resultado);
            }

        }
    }
}
