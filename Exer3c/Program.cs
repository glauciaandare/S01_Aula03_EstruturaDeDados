/*
Ler cinco valores numéricos inteiros, identificar e apresentar o maior e o menor
valores informados;
*/

using System;

namespace Exer3c {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite cinco números: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int numero3 = Convert.ToInt32(Console.ReadLine());
            int numero4 = Convert.ToInt32(Console.ReadLine());
            int numero5 = Convert.ToInt32(Console.ReadLine());

            //variaveis iniciam com o valor do primeiro numero
            int menor = numero1;
            int maior = numero1;

            // calculo do menor numero
            if (menor > numero2)
            {
                menor = numero2;
            } 
            if (menor > numero3)
            {
                menor = numero3;
            }
            if (menor > numero4)
            {
                menor = numero4;
            }
            if (menor > numero5)
            {
                menor = numero5;
            }

            //calculo do maior numero
            if (maior < numero2)
            {
                maior = numero2;
            }
            if (maior < numero3)
            {
                maior = numero3;
            }
            if (maior < numero4)
            {
                maior = numero4;
            }
            if(maior < numero5)
            {
                maior = numero5;
            }

            Console.WriteLine("O maior número digitado é: " + maior );
            Console.WriteLine("O menor número digitado é: " + menor );

            

        }
    }
}