/*
 * Uma pesquisa sobre o sabor de um novo refrigerante foi feita com várias pessoas.
As mesmas preenchiam uma tabela com 'O' de ótimo, 'B' de bom, 'R' de regular e
'U' de ruim. Faça um programa que leias as respostas coletadas pela pesquisa (as
letras 'O', 'B', 'R' e 'U') sendo que o fim das respostas será indicado por um traço '-'.
Outras letras devem ser desconsideradas. O programa deve também:
o indicar a quantidade de cada resposta,
o indicar o total de respostas,
o calcular a porcentagem de cada uma das respostas, e
o indicar se a soma de respostas 'O' e 'B' é maior ou não que a soma de respostas
'R' e 'U'.
*/

namespace Exer3h {
    class Program {
        static void Main(string[] args)
        {
            List<char> listaRespostas = new List<char>();

            char resposta = ' ';
            while (resposta != '-')
            {
                Console.Clear();
                Console.WriteLine(" O  Ótimo");
                Console.WriteLine(" B  Bom");
                Console.WriteLine(" R  Regular");
                Console.WriteLine(" U  Ruim");
                Console.WriteLine(" -  Sair");
                Console.WriteLine();
                Console.Write(" Opção: ");
                resposta = Convert.ToChar(Console.ReadLine().ToUpper());
                if (resposta == 'O' || resposta == 'B' || resposta == 'R' || resposta == 'U')
                    listaRespostas.Add(resposta);
            }

            int bom = 0, otimo = 0, regular = 0, ruim = 0, total = 0;
            foreach (char respostaAtual in listaRespostas)
            {
                total++;
                switch (respostaAtual)
                {
                    case 'B':
                        bom++;
                        break;
                    case 'O':
                        otimo++;
                        break;
                    case 'R':
                        regular++;
                        break;
                    case 'U':
                        ruim++;
                        break;
                }
            }
            Console.WriteLine($"Total de respostas = {total}");
            Console.WriteLine($"==================================");
            Console.WriteLine($"Ótimo teve....{otimo}... respostas");
            Console.WriteLine($"Bom teve......{bom}..... respostas");
            Console.WriteLine($"Regular teve..{regular}. respostas");
            Console.WriteLine($"Ruim teve.....{ruim}..... respostas");
            Console.WriteLine($"==================================");
            Console.WriteLine($"Ótimo teve....{(((float)otimo / (float)total) * 100).ToString("F1")}%... respostas");
            Console.WriteLine($"Bom teve......{(((float)bom / (float)total) * 100).ToString("F1")}%..... respostas");
            Console.WriteLine($"Regular teve..{(((float)regular / (float)total) * 100).ToString("F1")}%. respostas");
            Console.WriteLine($"Ruim teve.....{(((float)ruim / (float)total) * 100).ToString("F1")}%..... respostas");
            Console.WriteLine($"==================================");
            int soma_ob = otimo + bom;
            int soma_ru = regular + ruim;
            if (soma_ob > soma_ru)
                Console.WriteLine($"Soma de Otimos e bons ({soma_ob}) é maior que a soma dos regulares e ruins({soma_ru})");
        }
    }
}