//DESAFIO 09:

//Crie um algoritmo que dê um leque de opções de cursos para o usuário
//escolher e qual turma ele poderá ingressar, usando o conceito
//de "Switch-Case" na linguagem CSharp.

namespace Desafio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao sistema de escolha de cursos!");
            Console.WriteLine("Por favor, escolha o curso desejado:");

            Console.WriteLine("1. Análise e Desenvolvimento de Sistemas");
            Console.WriteLine("2. Ciências da Computação");
            Console.WriteLine("3. Engenharia Elétrica");
            Console.WriteLine("4. Química");
            Console.WriteLine("5. Odontologia");
            Console.WriteLine("6. Administração");

            int escolha;

            while (true)
            {
                Console.Write("Digite o número do curso (1 a 6): ");
                if (int.TryParse(Console.ReadLine(), out escolha) && escolha >= 1 && escolha <= 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Digite um número de 1 a 6.");
                }
            }

            string curso;
            string turma;

            switch (escolha)
            {
                case 1:
                    curso = "Matemática";
                    turma = "Turma A";
                    break;
                case 2:
                    curso = "Ciências da Computação";
                    turma = "Turma B";
                    break;
                case 3:
                    curso = "Engenharia Elétrica";
                    turma = "Turma C";
                    break;
                case 4:
                    curso = "Medicina";
                    turma = "Turma D";
                    break;
                case 5:
                    curso = "Arquitetura";
                    turma = "Turma E";
                    break;
                case 6:
                    curso = "Administração";
                    turma = "Turma F";
                    break;
                default:
                    
                    Console.WriteLine("Opção inválida. Escolha um número de 1 a 6.");
                    return;
            }

            Console.WriteLine($"Você escolheu o curso de {curso} na {turma}. Parabéns!");
        }
    }
}

