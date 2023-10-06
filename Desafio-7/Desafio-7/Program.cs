//DESAFIO 07:

//Uma loja de produtos eletrônicos com vendas regulares opta por contratar uma equipe
//para a organização de um sistema de gerenciamento de vendas. Elabore um algoritmo que,
//a partir de dados fornecidos pelo usuário, calcule o valor da  venda de um produto,
//exibindo uma saída em vídeo contendo o código do produto, o nome, a quantidade
//comprada, o valor unitário e o valor total.

namespace desafio7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Cadastrar Produto");
                Console.WriteLine("2. Registrar Venda");
                Console.WriteLine("3. Exibir Resumo de Vendas");
                Console.WriteLine("4. Encerrar Programa");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            CadastrarProduto(produtos);
                            break;
                        case 2:
                            RegistrarVenda(produtos, vendas);
                            break;
                        case 3:
                            ExibirResumoVendas(vendas);
                            break;
                        case 4:
                            Console.WriteLine("Encerrando o programa.");
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }

        static void CadastrarProduto(List<Produto> produtos)
        {
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço unitário: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade em estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            Produto produto = new Produto(codigo, nome, preco, estoque);
            produtos.Add(produto);

            Console.WriteLine("Produto cadastrado com sucesso.");
        }

        static void RegistrarVenda(List<Produto> produtos, List<Venda> vendas)
        {
            Console.Write("Digite o código do produto vendido: ");
            int codigo = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Codigo == codigo);

            if (produto != null)
            {
                Console.Write($"Digite a quantidade de '{produto.Nome}' vendida: ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade > 0 && quantidade <= produto.Estoque)
                {
                    Venda venda = new Venda(produto, quantidade);
                    vendas.Add(venda);

                    produto.AtualizarEstoque(quantidade);

                    Console.WriteLine("Venda registrada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Quantidade inválida ou insuficiente em estoque.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        static void ExibirResumoVendas(List<Venda> vendas)
        {
            Console.WriteLine("Resumo de Vendas:");

            if (vendas.Count > 0)
            {
                foreach (var venda in vendas)
                {
                    Console.WriteLine($"Código do Produto: {venda.Produto.Codigo}");
                    Console.WriteLine($"Nome do Produto: {venda.Produto.Nome}");
                    Console.WriteLine($"Quantidade Vendida: {venda.Quantidade}");
                    Console.WriteLine($"Preço Unitário: R$ {venda.Produto.Preco:F2}");
                    Console.WriteLine($"Valor Total: R$ {venda.ValorTotal:F2}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nenhuma venda registrada.");
            }
        }
    }

    class Produto
    {
        public int Codigo { get; }
        public string Nome { get; }
        public double Preco { get; }
        public int Estoque { get; private set; }

        public Produto(int codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void AtualizarEstoque(int quantidadeVendida)
        {
            Estoque -= quantidadeVendida;
        }
    }

    class Venda
    {
        public Produto Produto { get; }
        public int Quantidade { get; }
        public double ValorTotal => Produto.Preco * Quantidade;

        public Venda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}

