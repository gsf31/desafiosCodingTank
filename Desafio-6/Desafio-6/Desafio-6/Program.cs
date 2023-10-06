//DESAFIO 06:

//Elabore um algoritmo que dada a idade de um nadador, classifique-o em uma das 
//seguintes categorias:
//Infantil A = 5 a 7 anos.
//Infantil B = 8 a 11 anos.
//Juvenil A = 12 a 13 anos.
//Juvenil B = 14 a 17 anos.
//Adultos = Maiores de 18 anos.
//Apresentar as mensagens no console com a classificação.

namespace desafio06
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite a idade do nadador: ");
                string idadeInput = Console.ReadLine();

                if (idadeInput.Length <= 3) 
                {
                    int idade = int.Parse(idadeInput);
                    string categoria = "";

                    if (idade >= 5 && idade <= 7)
                    {
                        categoria = "Infantil A";
                    }
                    else if (idade >= 8 && idade <= 11)
                    {
                        categoria = "Infantil B";
                    }
                    else if (idade >= 12 && idade <= 13)
                    {
                        categoria = "Juvenil A";
                    }
                    else if (idade >= 14 && idade <= 17)
                    {
                        categoria = "Juvenil B";
                    }
                    else if (idade >= 18)
                    {
                        categoria = "Adultos";
                    }
                    else
                    {
                        categoria = "Idade fora das categorias especificadas";
                    }

                    Console.WriteLine($"O nadador está na categoria: {categoria}");
                }
                else
                {
                    Console.WriteLine("Idade inválida. Verifique novamente se a idade está correta.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar uma idade válida.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}

