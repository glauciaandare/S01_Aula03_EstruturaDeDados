/*Ler os valores de quatro notas escolares de um aluno. Calcular a média aritmética e
apresentar a mensagem “Aprovado” se a média obtida for maior ou igual a 5; caso
contrário, apresentar a mensagem “Reprovado”. Informar com cada mensagem o
valor da média obtida;
*/
using System;

namespace Exer3a {
    internal class Program {
        static void Main(string[] args)
        {   
            double nota1, nota2, nota3, nota4;
            double media;


            Console.WriteLine("Informar as quatro notas: ");
            nota1 = Convert.ToDouble(Console.ReadLine()); 
            nota2 = Convert.ToDouble(Console.ReadLine()); 
            nota3 = Convert.ToDouble(Console.ReadLine()); 
            nota4 = Convert.ToDouble(Console.ReadLine()); 

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 5)
            {
                Console.WriteLine("O Aluno foi Aprovado");
            } else

            Console.WriteLine("O Aluno foi Reprovado");
        }
    }
}