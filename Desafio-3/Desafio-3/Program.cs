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

                Console.Write("Você deseja dar gorjeta de 15% ou 20%: ");
                double porcentagemGorjeta = double.Parse(Console.ReadLine());
                if (porcentagemGorjeta == 0)
                {
                    Console.WriteLine("Obrigado. Volte sempre!");
                }
                else
                {
                    double valorGorjeta = (valorConta * porcentagemGorjeta) / 100.0;
                    double totalPago = valorConta + valorGorjeta;

                    Console.WriteLine($"Valor da gorjeta: R$ {valorGorjeta}");
                    Console.WriteLine($"Total a ser pago: R$ {totalPago}");
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

