/******************************************************************************
 Crie um programa que gerencie uma lista de produtos. 
 Cada produto deve ter um nome, um preço e uma quantidade em estoque.

Tarefas:

Adicionar novos produtos à lista.
Remover um produto da lista pelo nome.
Atualizar a quantidade em estoque de um produto.
Ordenar a lista de produtos pelo nome.
Exibir todos os produtos.

*******************************************************************************/
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    List<Produtos> produtos = new List<Produtos>();

    Console.Write("Deseja incluir quantos itens na lista inicialmente? ");
    int n = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < n; i++){
        Console.Write($"produto #{i+1}: ");
        string nome = Console.ReadLine();
        
        Console.Write("Preco do produto: $");
        double preco = double.Parse(Console.ReadLine());
        
        Console.Write("Quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        
         produtos.Add(new Produtos(nome,preco,quantidade));
    }
    produtos.Sort((p1, p2) => p1.Nome.CompareTo(p2.Nome));
        
        ExibirProdutos(produtos);
        
        Console.WriteLine("Você deseja remover algum item da lista? (S/N)");
        char escolha = char.Parse(Console.ReadLine().ToUpper());
        if(escolha == 'S'){
            Console.Write("Qual item deseja remover?");
            string nomeParaRemover = Console.ReadLine();
            RemoverProduto(produtos, nomeParaRemover);
            ExibirProdutos(produtos);
        }
        Console.Write("Você deseja atualizar a quantidade em estoque de algum item? (S/N)");
        escolha = char.Parse(Console.ReadLine().ToUpper());
        if (escolha == 'S') {
            Console.Write("Qual o nome do produto que deseja atualizar? ");
            string nomeParaAtualizar = Console.ReadLine();
            Console.Write("Nova quantidade em estoque: ");
            int novaQuantidade = int.Parse(Console.ReadLine());
            AtualizarQuantidade(produtos, nomeParaAtualizar, novaQuantidade);
            ExibirProdutos(produtos);
  
        }
    }
  
  static void ExibirProdutos(List<Produtos> produtos){
       Console.WriteLine("Lista de produtos ordenada por nome: ");
        foreach (var produto in produtos) {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C}, Quantidade: {produto.Quantidade}");
        }
        Console.WriteLine();
  }
  static void RemoverProduto(List<Produtos> produtos, string nome){
       Produtos produtoParaRemover = produtos.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (produtoParaRemover != null) {
            produtos.Remove(produtoParaRemover);
            Console.WriteLine($"Produto '{nome}' removido com sucesso.");
        } else {
            Console.WriteLine($"Produto '{nome}' não encontrado.");
        }
  }
   static void AtualizarQuantidade(List<Produtos> produtos, string nome, int novaQuantidade) {
        Produtos produtoParaAtualizar = produtos.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (produtoParaAtualizar != null) {
            produtoParaAtualizar.Quantidade = novaQuantidade;
            Console.WriteLine($"Quantidade do produto '{nome}' atualizada com sucesso.");
        } else {
            Console.WriteLine($"Produto '{nome}' não encontrado.");
        }
}
class Produtos{
    public string Nome {get;set;}
    public double Preco {get;set;}
    public int Quantidade {get;set;}
    
    public Produtos(string nome, double preco, int quantidade){
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
  }
}
