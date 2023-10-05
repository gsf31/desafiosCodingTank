namespace desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o valor em reais: ");
                double valorReais = double.Parse(Console.ReadLine());

                double taxaDolar = 5.16; //Tá alto de novo ;-;
                double taxaEuro = 5.46; //Tá difícil ir para a Europa '-'

                double valorDolar = valorReais / taxaDolar;
                double valorEuro = valorReais / taxaEuro;

                Console.WriteLine($"Valor em dólares: {valorDolar:F2}");
                Console.WriteLine($"Valor em euros: {valorEuro:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Esse programa só aceita valores numéricos.");
            }
        }
    }
}

