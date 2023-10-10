namespace DesafioAdivinharNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gerando um número secreto aleatório entre 1 e 100.
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int tentativas = 0;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

            int palpite;

            do
            {
                Console.Write("Digite o seu palpite: ");
                string palpiteStr = Console.ReadLine();

                if (int.TryParse(palpiteStr, out palpite))
                {
                    tentativas++;

                    if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("O número secreto é maior. Tente novamente.");
                    }
                    else if (palpite > numeroSecreto)
                    {
                        Console.WriteLine("O número secreto é menor. Tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {tentativas} tentativas.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }

            } while (palpite != numeroSecreto);

            Console.WriteLine("O jogo terminou. Obrigado por jogar!");
        }
    }
}
