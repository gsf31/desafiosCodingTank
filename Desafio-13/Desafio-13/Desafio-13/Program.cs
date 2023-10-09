namespace desafio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumeros = 10;
            int[] numeros = new int[quantidadeNumeros];

            // Solicita ao usuário que insira 10 números inteiros
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numeros[i] = numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                    i--; // Repete a entrada para o índice atual
                }
            }

            int soma = 0;
            int menor = numeros[0];

            // Calcula a soma e encontra o menor número
            foreach (int numero in numeros)
            {
                soma += numero;
                if (numero < menor)
                {
                    menor = numero;
                }
            }

            double media = (double)soma / quantidadeNumeros;

            Console.WriteLine($"Soma dos números: {soma}");
            Console.WriteLine($"Média dos números: {media:F2}");
            Console.WriteLine($"Menor número: {menor}");
        }
    }
}
