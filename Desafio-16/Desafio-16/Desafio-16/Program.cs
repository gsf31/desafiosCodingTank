namespace desafio16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Digite o limite inferior do intervalo (ou digite '0' para sair): ");
                string entradaInferior = Console.ReadLine();

                if (entradaInferior == "0")
                {
                    Console.WriteLine("Programa encerrado.");
                    continuar = false;
                    break;
                }

                Console.Write("Digite o limite superior do intervalo: ");
                string entradaSuperior = Console.ReadLine();

                if (int.TryParse(entradaInferior, out int limiteInferior) && int.TryParse(entradaSuperior, out int limiteSuperior)
                    && entradaInferior.TrimStart('0') == entradaInferior && entradaSuperior.TrimStart('0') == entradaSuperior)
                {
                    if (limiteInferior <= limiteSuperior)
                    {
                        int somaPares = 0;
                        string numerosPares = "";

                        for (int numero = limiteInferior; numero <= limiteSuperior; numero++)
                        {
                            if (numero % 2 == 0)
                            {
                                somaPares += numero;
                                numerosPares += numero + " ";
                            }
                        }

                        Console.WriteLine($"A soma dos números pares no intervalo de {limiteInferior} a {limiteSuperior} é: {somaPares}");
                        Console.WriteLine($"Números pares no intervalo: {numerosPares}");
                    }
                    else
                    {
                        Console.WriteLine("O limite inferior deve ser menor ou igual ao limite superior.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Certifique-se de inserir números inteiros válidos sem zeros à esquerda e um intervalo válido.");
                }
            }
        }
    }
}
