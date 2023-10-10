using System;
using System.Numerics;

namespace desafio172
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite quantos termos da sequência de Fibonacci você deseja gerar: ");
            string entrada = Console.ReadLine();

            if (BigInteger.TryParse(entrada, out BigInteger n) && n >= 1)
            {
                Console.WriteLine($"Sequência de Fibonacci com {n} termos:");

                for (BigInteger i = 0; i < n; i++)
                {
                    Console.Write(CalcularFibonacci(i) + " ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar um número inteiro positivo.");
            }
        }

        static BigInteger CalcularFibonacci(BigInteger n)
        {
            if (n <= 1)
            {
                return n;
            }

            BigInteger[,] matriz = { { 1, 1 }, { 1, 0 } };
            PotenciaMatriz(matriz, n - 1);

            return matriz[0, 0];
        }

        static void MultiplicarMatriz(BigInteger[,] matrizA, BigInteger[,] matrizB)
        {
            BigInteger a = matrizA[0, 0] * matrizB[0, 0] + matrizA[0, 1] * matrizB[1, 0];
            BigInteger b = matrizA[0, 0] * matrizB[0, 1] + matrizA[0, 1] * matrizB[1, 1];
            BigInteger c = matrizA[1, 0] * matrizB[0, 0] + matrizA[1, 1] * matrizB[1, 0];
            BigInteger d = matrizA[1, 0] * matrizB[0, 1] + matrizA[1, 1] * matrizB[1, 1];

            matrizA[0, 0] = a;
            matrizA[0, 1] = b;
            matrizA[1, 0] = c;
            matrizA[1, 1] = d;
        }

        static void PotenciaMatriz(BigInteger[,] matriz, BigInteger n)
        {
            if (n <= 1)
            {
                return;
            }

            PotenciaMatriz(matriz, n / 2);
            MultiplicarMatriz(matriz, matriz);

            BigInteger[,] temp = { { 1, 1 }, { 1, 0 } };
            if (n % 2 == 1)
            {
                MultiplicarMatriz(matriz, temp);
            }
        }
    }
}
