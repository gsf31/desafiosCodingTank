﻿namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o primeiro número que deseja fazer as operações: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número que deseja fazer as operações: ");
                int numero2 = int.Parse(Console.ReadLine());

                int soma = numero1 + numero2;
                int subtrai = numero1 - numero2;
                int multiplica = numero1 * numero2;

                if (numero2 != 0)
                {
                    double divide = (double)numero1 / numero2;
                    Console.WriteLine($"soma = {soma}, subtração = {subtrai}, multiplicação = {multiplica}, divisão = {divide}");
                }
                else
                {
                    Console.WriteLine("Não é possível fazer divisão por zero. Escolha outro número.");

                }                
            }
            catch(FormatException)
            {
                Console.WriteLine("Entrada inválida: O programa só aceita valores númericos. Tente novamente.");
            }
        }
    }
}
