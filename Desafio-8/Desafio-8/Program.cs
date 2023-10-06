//DESAFIO 08:

//Um aluno realizou três provas de uma determinada disciplina. Levando em consideração o
//critério apresentado a seguir, faça um programa que mostre se ele ficou para exame final,
//e caso positivo, que nota o aluno precisará obter para passar de ano.

//"Média = (Prova 1 + Prova 2 + Prova 3) / 3"

//A média deve ser igual ou maior que 7,0. Caso o aluno não consiga, a nova média deve ser:

//"Final = (Média + Exame) / 2"

//A média final para a aprovação deve ser igual ou maior que 5,0.

using System;
using System.Globalization;

namespace desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular a média e verificar se o aluno passou no exame.");

            CultureInfo cultureInfo = CultureInfo.InvariantCulture; // Cultura invariável para aceitar ponto ou vírgula como separador decimal
            double prova1, prova2, prova3;

            Console.Write("Digite a nota da Prova 1: ");
            while (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float, cultureInfo, out prova1))
            {
                Console.Write("Digite uma nota válida da Prova 1: ");
            }

            Console.Write("Digite a nota da Prova 2: ");
            while (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float, cultureInfo, out prova2))
            {
                Console.Write("Digite uma nota válida da Prova 2: ");
            }

            Console.Write("Digite a nota da Prova 3: ");
            while (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float, cultureInfo, out prova3))
            {
                Console.Write("Digite uma nota válida da Prova 3: ");
            }

            double media = (prova1 + prova2 + prova3) / 3;

            if (media >= 7.0)
            {
                Console.WriteLine("O aluno está aprovado com média " + media.ToString("F1", cultureInfo));
            }
            else
            {
                Console.WriteLine("O aluno precisa fazer o exame final.");
                Console.Write("Digite a nota do exame final: ");

                double exameFinal;
                while (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float, cultureInfo, out exameFinal))
                {
                    Console.Write("Digite uma nota válida do exame final: ");
                }

                double mediaFinal = (media + exameFinal) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("O aluno está aprovado após o exame final com média " + mediaFinal.ToString("F1", cultureInfo));
                }
                else
                {
                    Console.WriteLine("O aluno está reprovado com média final " + mediaFinal.ToString("F1", cultureInfo));
                }
            }
        }
    }
}

