namespace desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o ano atual: ");
                int anoAtual = int.Parse(Console.ReadLine());

                Console.Write("Digite o ano do seu nascimento: ");
                int anoNascimento = int.Parse(Console.ReadLine());

                if (anoAtual < anoNascimento)
                {
                    throw new Exception("O ano atual não pode ser menor que o ano de nascimento");
                }

                int idade = anoAtual - anoNascimento;

                Console.WriteLine($"Você tem {idade} anos.");
            }
            catch(FormatException)
            {
                Console.WriteLine("Esse programa só aceita valores númericos.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}