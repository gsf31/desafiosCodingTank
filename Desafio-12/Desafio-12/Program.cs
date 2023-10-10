//Exercício 01: 
//Faça um algoritmo que construa dois vetores A e B de 10 elementos e,
//a partir deles, crie um vetor C, composto pela somados elementos, sendo: 

//C[1] = A[1] + B[9], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc.

namespace DesafioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 10;

            int[] A = new int[tamanho];
            int[] B = new int[tamanho];
            int[] C = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                A[i] = i + 1; 
                B[i] = tamanho - i; 
            }

            for (int i = 0; i < tamanho; i++)
            {
                C[i] = A[i] + B[tamanho - i - 1];
            }

            Console.WriteLine("Vetor A:");
            ImprimirVetor(A);

            Console.WriteLine("\nVetor B:");
            ImprimirVetor(B);

            Console.WriteLine("\nVetor C (soma de A e B com padrão especificado):");
            ImprimirVetor(C);
        }

        static void ImprimirVetor(int[] vetor)
        {
            foreach (int elemento in vetor)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
    }
}

