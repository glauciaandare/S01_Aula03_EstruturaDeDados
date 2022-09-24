/*
 * Leia três números quaisquer, imprimindo-os em ordem crescente.
 */

namespace Exer3d {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe três números: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if(numero1 < numero2)
            {
                if (numero2 < numero3)
                {
                    Console.WriteLine("Ordem Crescente: " + numero1 + " " + numero2 + " " + numero3);
                }
                else
                {
                    Console.WriteLine("Ordem Crescente: " + numero1 + " " + numero3 + " " + numero2);
                }
            }
            else
            {
                if(numero2 < numero3)
                {
                    if( numero1 < numero3)
                    {
                        Console.WriteLine("Ordem Crescente: " + numero2 + " " + numero1 +  " " + numero3);
                    }
                    else
                    {
                        Console.WriteLine("Ordem Crescente: " + numero2 + " " + numero3 + " " + numero1);
                    }
                }
                else
                {
                    if(numero1 < numero2)
                    {
                        Console.WriteLine("Ordem Crescente: " + numero3 + " " + numero1 + " " + numero2);
                    }
                    else
                    {
                        Console.WriteLine("Ordem Crescente: " + numero3 + " " + numero2 + " " + numero1);
                    }
                }
            }
        }
    }
}