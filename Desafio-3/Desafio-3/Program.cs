namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o valor total da conta: ");
                double valorConta = double.Parse(Console.ReadLine());

                if (valorConta < 0)
                {
                    Console.WriteLine("Saia, saia imediatamente Corbucci!");
                    return;
                }

                Console.Write("Você deseja dar gorjeta de 15% ou 20% (ou 0 para não dar gorjeta): ");
                double porcentagemGorjeta = double.Parse(Console.ReadLine());

                if (porcentagemGorjeta == 0)
                {
                    Console.WriteLine("Obrigado. Volte sempre!");
                }
                else
                {
                    double valorGorjeta = (valorConta * porcentagemGorjeta) / 100.0;
                    double totalPago = valorConta + valorGorjeta;

                    Console.WriteLine($"Valor da gorjeta: R$ {valorGorjeta:F2}");
                    Console.WriteLine($"Total a ser pago: R$ {totalPago:F2}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Esse programa só aceita valores numéricos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
