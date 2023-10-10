namespace desafio17
{
    class Program
    {
        static void Main()
        {
            try
            {
                int n;

                if (ObterNumeroTermos(out n))
                {
                    ExibirSequenciaFibonacci(n);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Certifique-se de digitar um número inteiro positivo.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }

        static bool ObterNumeroTermos(out int n)
        {
            Console.Write("Digite quantos termos da sequência de Fibonacci você deseja gerar: ");
            string entrada = Console.ReadLine();
            return int.TryParse(entrada, out n) && n >= 1;
        }

        static void ExibirSequenciaFibonacci(int n)
        {
            int primeiroTermo = 0;
            int segundoTermo = 1;

            Console.WriteLine($"Sequência de Fibonacci com {n} termos:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(primeiroTermo + " ");

                int proximoTermo = primeiroTermo + segundoTermo;
                primeiroTermo = segundoTermo;
                segundoTermo = proximoTermo;
            }

            Console.WriteLine();
        }
    }
}

