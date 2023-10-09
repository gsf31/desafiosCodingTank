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
            int tamanho = 10; // Tamanho dos vetores A, B e C

            int[] A = new int[tamanho];
            int[] B = new int[tamanho];
            int[] C = new int[tamanho];

            // Preencha os vetores A e B com valores, aqui estamos apenas preenchendo com números sequenciais para exemplo
            for (int i = 0; i < tamanho; i++)
            {
                A[i] = i + 1; // A[0] = 1, A[1] = 2, A[2] = 3, ...
                B[i] = tamanho - i; // B[0] = 10, B[1] = 9, B[2] = 8, ...
            }

            // Crie o vetor C com base na soma dos elementos de A e B no padrão especificado
            for (int i = 0; i < tamanho; i++)
            {
                C[i] = A[i] + B[tamanho - i - 1];
            }

            // Exiba os vetores A, B e C
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

