//DESAFIO 10:

//Palavras palíndromos são aquelas que são lidas da direita para a esquerda da mesma
//maneira que da esquerda para a direita. Exemplo ARARA. Dado uma palavra, informar se ela
//é palíndroma ou não.

namespace IdentificadorPalindromos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra para verificar se é um palíndromo:");
            string entrada = Console.ReadLine().ToLower(); 

            bool ePalindromo = VerificarPalindromo(entrada);

            if (ePalindromo)
            {
                Console.WriteLine("É um palíndromo!");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo.");
            }
        }

        static bool VerificarPalindromo(string texto)
        {
            string textoLimpo = new string(texto.ToCharArray().Where(c => Char.IsLetterOrDigit(c)).ToArray());

            int esquerda = 0;
            int direita = textoLimpo.Length - 1;

            while (esquerda < direita)
            {
                if (textoLimpo[esquerda] != textoLimpo[direita])
                {
                    return false; 
                }

                esquerda++;
                direita--;
            }

            return true; 
        }
    }
}
