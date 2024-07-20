using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<Produto> produtos = new List<Produto>();
        char escolha = '0';
        
        while (escolha != '6') {
            ExibirMenu();
            escolha = LerEscolhaUsuario();
            
            switch (escolha) {
                case '1':
                    AdicionarProduto(produtos);
                    break;
                case '2':
                    RemoverProduto(produtos);
                    break;
                case '3':
                    AtualizarQuantidadeProduto(produtos);
                    break;
                case '4':
                    ExibirProdutos(produtos);
                    break;
                case '5':
                    OrdenarProdutos(produtos);
                    break;
                case '6':
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void ExibirMenu() {
        Console.Clear();
        Console.WriteLine("Gerenciamento de Inventário de Produtos");
        Console.WriteLine("1. Adicionar produto");
        Console.WriteLine("2. Remover produto pelo nome");
        Console.WriteLine("3. Atualizar quantidade em estoque");
        Console.WriteLine("4. Exibir todos os produtos");
        Console.WriteLine("5. Ordenar produtos pelo nome");
        Console.WriteLine("6. Sair");
        Console.Write("Escolha uma opção: ");
    }

    static char LerEscolhaUsuario() {
        char escolha;
        while (!char.TryParse(Console.ReadLine(), out escolha) || escolha < '1' || escolha > '6') {
            Console.WriteLine("Entrada inválida. Por favor, escolha uma opção de 1 a 6.");
            Console.Write("Escolha uma opção: ");
        }
        return escolha;
    }

    static void AdicionarProduto(List<Produto> produtos) {
        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine();
        
        Console.Write("Preço do produto: ");
        double preco = LerPrecoProduto();

        Console.Write("Quantidade em estoque: ");
        int quantidade = LerQuantidadeProduto();

        produtos.Add(new Produto(nome, preco, quantidade));
        Console.WriteLine("Produto adicionado com sucesso!");
        Console.ReadKey();
    }

    static double LerPrecoProduto() {
        double preco;
        while (!double.TryParse(Console.ReadLine(), out preco) || preco < 0) {
            Console.WriteLine("Preço inválido. Por favor, insira um preço positivo.");
            Console.Write("Preço do produto: ");
        }
        return preco;
    }

    static int LerQuantidadeProduto() {
        int quantidade;
        while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0) {
            Console.WriteLine("Quantidade inválida. Por favor, insira uma quantidade positiva.");
            Console.Write("Quantidade em estoque: ");
        }
        return quantidade;
    }

    static void RemoverProduto(List<Produto> produtos) {
        Console.Write("Nome do produto a ser removido: ");
        string nome = Console.ReadLine();
        
        Produto produtoParaRemover = EncontrarProdutoPorNome(produtos, nome);
        if (produtoParaRemover != null) {
            produtos.Remove(produtoParaRemover);
            Console.WriteLine("Produto removido com sucesso!");
        } else {
            Console.WriteLine("Produto não encontrado.");
        }
        Console.ReadKey();
    }

    static void AtualizarQuantidadeProduto(List<Produto> produtos) {
        Console.Write("Nome do produto a ser atualizado: ");
        string nome = Console.ReadLine();
        
        Produto produtoParaAtualizar = EncontrarProdutoPorNome(produtos, nome);
        if (produtoParaAtualizar != null) {
            Console.Write("Nova quantidade em estoque: ");
            produtoParaAtualizar.Quantidade = LerQuantidadeProduto();
            Console.WriteLine("Quantidade atualizada com sucesso!");
        } else {
            Console.WriteLine("Produto não encontrado.");
        }
        Console.ReadKey();
    }

    static Produto EncontrarProdutoPorNome(List<Produto> produtos, string nome) {
        return produtos.Find(produto => produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }

    static void ExibirProdutos(List<Produto> produtos) {
        Console.WriteLine("Lista de Produtos:");
        foreach (var produto in produtos) {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C}, Quantidade: {produto.Quantidade}");
        }
        Console.ReadKey();
    }

    static void OrdenarProdutos(List<Produto> produtos) {
        produtos.Sort((p1, p2) => p1.Nome.CompareTo(p2.Nome));
        Console.WriteLine("Produtos ordenados pelo nome.");
        Console.ReadKey();
    }
}

class Produto {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade) {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
}
