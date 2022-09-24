
/*Ler os valores de quatro notas escolares de um aluno. Calcular a média aritmética e
apresentar a mensagem “Aprovado” se a média obtida for maior ou igual a 7; caso
contrário, o programa deve solicitar a nota de exame do aluno e calcular uma nova
média aritmética entre a nota de exame e a primeira média aritmética. Se o valor
da nova média for maior ou igual a cinco, apresentar a mensagem “Aprovado em
exame”; caso contrário, apresentar a mensagem “Reprovado”. Informar junto com
cada mensagem o valor da média obtida;
*/

using System;
namespace Exer3b {
    internal class Program {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, notaExame;
            double media, mediaNova;            
                        
            Console.WriteLine("Informar a nota1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informar a nota2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informar a nota3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informar a nota1: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("O Aluno foi Aprovado");
            }
            else
            {
                Console.WriteLine("Informa a nota do Exame:");
                notaExame = Convert.ToDouble(Console.ReadLine());

                mediaNova = (notaExame + media) / 2;

                if (mediaNova >= 5)
                {
                    Console.WriteLine("Aprovado em Exame, com a media: " + mediaNova);
                }
                else
                {
                    Console.WriteLine("Reprovado em Exame, com a media: " + mediaNova);

                }
            }
            
        }
    }
}
