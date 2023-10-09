namespace LeituraNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int numerosLidos = 0;
            int numerosPares = 0;

            Console.WriteLine("Digite números (digite 0 para finalizar):");

            while (true)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break; // Sai do loop quando o usuário digitar 0
                }

                numerosLidos++;
                soma += numero;

                if (numero % 2 == 0)
                {
                    numerosPares++;
                }
            }

            Console.WriteLine($"Total de números lidos: {numerosLidos}");
            Console.WriteLine($"Soma dos números: {soma}");
            Console.WriteLine($"Quantidade de números pares: {numerosPares}");
        }
    }
}

