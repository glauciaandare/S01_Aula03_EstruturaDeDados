/*
 * Fazer um programa que dada a altura e peso de uma pessoa, calcule seu índice
de massa corporal. Fórmula: Peso / Altura2. Em seguida, mostre em que faixa
de peso a pessoa se encontra. Faixas: <= 18,5 - abaixo do peso normal; > 18,5 e
<= 25 - peso normal; > 25 e <=30 - peso acima do normal; acima de 30 - peso
excessivo.
*/
namespace Exer3f {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o Peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            double massaCorporal = (peso / (altura * altura));

            if (massaCorporal <= 18.5)
            {
                Console.WriteLine("Massa corporal = " + massaCorporal + " Está abaixo do peso normal; ");
            }
            else if (massaCorporal <= 25 && massaCorporal > 18.5)
            {
                Console.WriteLine("Massa corporal = " + massaCorporal + " Está no peso normal; ");
            }
            else if (massaCorporal <= 30 && massaCorporal > 25)
            {
                Console.WriteLine("Massa corporal = " + massaCorporal + " Está acima do peso normal; ");
            }
            else 
            {
                Console.WriteLine("Massa corporal = " + massaCorporal + " Está com peso excessivo; ");
            }
        }
    }
}