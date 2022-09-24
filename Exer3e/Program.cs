namespace Exer3e {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 0.0 && nota <= 1.9)
            {
                Console.WriteLine("Conceito E");
            }
            else if (nota >= 2.0 && nota <= 4.9)
            {
                Console.WriteLine("Conceito D");
            }
            else if (nota >= 5.0 && nota <= 6.9)
            {
                Console.WriteLine("Conceito C");
            }
            else if (nota >= 7.0 && nota <= 8.9)
            {
                Console.WriteLine("Conceito B");
            }
            else
                Console.WriteLine("Conceito A");
        }   
        

    }
}
        
        