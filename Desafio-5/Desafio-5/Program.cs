//DESAFIO 05:
//Sr.José, pescador, comprou um microcomputador para
//controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de
//peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo
//(50 quilos) deve pagar uma multa de R$4,00 por quilo excedente. Sr. José, precisa que
//você faça programa que leia o peso de peixes e verifique se há excesso.
//Se houver, gravar o Excesso e o valor da multa que Sr. José
//deverá pagar. Caso contrário mostrar os valores com o conteúdo ZERO. 
//Apresentar as mensagens no console.

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const double limitePeso = 50.0;
                const double valorMultaPorQuiloExcedente = 4.0;

                double totalMulta = 0.0;

                List<string> extratoMultas = new List<string>();

                Console.WriteLine("Bem-vindo ao programa de controle de multas Sr. José!");

                while (true)
                {
                    Console.WriteLine("\nEscolha uma opção:");
                    Console.WriteLine("1. Calcular Multa");
                    Console.WriteLine("2. Ver Extrato Atual de Multas");
                    Console.WriteLine("0. Sair");

                    Console.Write("Digite o número da opção desejada: ");
                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 0:
                            Console.WriteLine("Encerrando o programa.");
                            Environment.Exit(0);
                            break;

                        case 1:
                            Console.Write("Digite o peso dos peixes em quilos: ");
                            double pesoPeixes = double.Parse(Console.ReadLine());

                            if (pesoPeixes < 0)
                            {
                                Console.WriteLine("Peso não pode ser negativo. Tente novamente.");
                            }
                            else if (pesoPeixes > limitePeso)
                            {
                                double excesso = pesoPeixes - limitePeso;
                                double multa = excesso * valorMultaPorQuiloExcedente;

                                Console.WriteLine($"Excesso de peso: {excesso} quilos");
                                Console.WriteLine($"Valor da multa a pagar: R$ {multa:F2}");

                                totalMulta += multa;

                                extratoMultas.Add($"Excesso: {excesso} kg, Multa: R$ {multa:F2}");
                            }
                            else
                            {
                                Console.WriteLine("Não há excesso de peso. Multa: R$ 0.00");
                            }
                            break;

                        case 2:
                            Console.WriteLine("\nExtrato Atual de Multas:");
                            foreach (var entrada in extratoMultas)
                            {
                                Console.WriteLine(entrada);
                            }
                            Console.WriteLine($"Total de multa paga até o momento: R$ {totalMulta:F2}");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar um valor numérico.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}