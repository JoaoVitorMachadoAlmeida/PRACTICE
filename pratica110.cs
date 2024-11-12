/*
Exercício: Análise de Vendas de Produtos
Você tem uma lista de vendas de produtos, onde cada venda possui as seguintes propriedades:

ProdutoId (int): Identificador único do produto.
NomeProduto (string): Nome do produto vendido.
Categoria (string): Categoria do produto (ex: Eletrônicos, Utensílios, Alimentos, etc.).
QuantidadeVendida (int): Quantidade de itens vendidos.
PrecoUnitario (decimal): Preço de cada unidade do produto.
DataVenda (DateTime): Data da venda.
Objetivo: Usando LINQ, realize as seguintes operações:

Total de Vendas por Categoria:
Agrupe as vendas pela Categoria e calcule o valor total de vendas para cada categoria (ou seja, a soma de QuantidadeVendida * PrecoUnitario para cada venda na categoria).

Produto Mais Vendido por Quantidade:
Encontre o produto que teve a maior QuantidadeVendida em todas as vendas (independentemente da categoria). Exiba o NomeProduto e a quantidade total vendida.

Top 3 Produtos com Maior Receita:
Calcule o total de receita (quantidade vendida * preço unitário) para cada produto e exiba uma lista com os três produtos que geraram a maior receita.

Vendas Mensais por Produto:
Agrupe as vendas por NomeProduto e por mês (DataVenda.Month). Para cada produto, exiba o mês e a quantidade total vendida naquele mês.

Produtos Não Vendidos:
Selecione todos os produtos da lista que nunca foram vendidos (ou seja, a QuantidadeVendida é zero em todas as vendas desse produto).
*/
using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var vendas = new List<Venda>
{
    new Venda(1, "Laptop", "Eletrônicos", 5, 1500.00m, new DateTime(2023, 5, 14)),
    new Venda(2, "Smartphone", "Eletrônicos", 8, 800.00m, new DateTime(2023, 5, 16)),
    new Venda(3, "Tablet", "Eletrônicos", 0, 600.00m, new DateTime(2023, 5, 20)),
    new Venda(4, "Fogão", "Eletrodomésticos", 2, 1200.00m, new DateTime(2023, 6, 25)),
    new Venda(5, "Geladeira", "Eletrodomésticos", 3, 2500.00m, new DateTime(2023, 7, 10)),
    new Venda(6, "Arroz", "Alimentos", 15, 20.00m, new DateTime(2023, 6, 5)),
    new Venda(7, "Feijão", "Alimentos", 10, 15.00m, new DateTime(2023, 6, 7)),
    new Venda(8, "Smartphone", "Eletrônicos", 5, 800.00m, new DateTime(2023, 7, 12)),
    new Venda(9, "TV", "Eletrônicos", 0, 2000.00m, new DateTime(2023, 5, 20)),
};
		/*
		Total de Vendas por Categoria:
        Agrupe as vendas pela Categoria e calcule o valor total de vendas para cada categoria 
        (ou seja, a soma de QuantidadeVendida * PrecoUnitario para cada venda na categoria).
		*/
		var categoria = vendas
		.GroupBy(x => x.Categoria)
		.Select(x => new
		{
		    Categoria = x.Key,
		    TotalVendas = x.Sum(v => v.QuantidadeVendida * v.PrecoUnitario)
		})
		.ToList();
		
		Console.WriteLine("Total de vendas por categoria: ");
		
		foreach(var item in categoria)
		{
		    Console.WriteLine($"Categoria: {item.Categoria}, Total: {item.TotalVendas}");
		}


		Console.WriteLine();
		
		/*
	    Produto Mais Vendido por Quantidade:
        Encontre o produto que teve a maior QuantidadeVendida em todas as vendas (independentemente da categoria). 
        Exiba o NomeProduto e a quantidade total vendida.
		*/
		var maioresVendas = vendas
		.OrderByDescending(x => x.QuantidadeVendida)
		.Select(x => new {x.NomeProduto, x.QuantidadeVendida})
		.First();
		
		
		Console.WriteLine($"Maior quantidade de vendas:\nProduto: {maioresVendas.NomeProduto}, Quantidade: {maioresVendas.QuantidadeVendida}");
		
		
		Console.WriteLine();
		
		/*
		Top 3 Produtos com Maior Receita:
Calcule o total de receita (quantidade vendida * preço unitário) para cada produto e exiba uma lista com os três produtos que geraram a maior receita.
		*/
		var receita = vendas
		.GroupBy(x => x.NomeProduto)
		.Select( x => new
		 {
		     NomeProduto = x.Key,
		     TotalReceita = x.Sum(r => r.QuantidadeVendida * r.PrecoUnitario)
		 })
		 .OrderByDescending(x => x.TotalReceita)
		 .Take(3)
		 .ToList();
		
		
		Console.WriteLine("Maiores receitas: ");
		
		foreach(var item in receita)
		{
			Console.WriteLine($"Nome: {item.NomeProduto}, Total Receita: {item.TotalReceita}");
		}
		Console.WriteLine();
		
		/*Vendas Mensais por Produto:
        Agrupe as vendas por NomeProduto e por mês (DataVenda.Month). Para cada produto, 
        exiba o mês e a quantidade total vendida naquele mês.
        */
        var vendasPorMes = vendas
        .GroupBy(x => new {x.NomeProduto, Mes = x.DataVendas.Month})
        .Select(g => new
        {
            NomeProduto = g.Key.NomeProduto,
            Mes = g.Key.Mes,
            TotalVendas = g.Sum(v => v.QuantidadeVendida * v.PrecoUnitario)
        })
        .ToList();
        
        foreach(var item in vendasPorMes)
        {
            Console.WriteLine($"Nome: {item.NomeProduto}, Mês: {item.Mes}, Vendas total: {item.TotalVendas:F2}");
        }
        /*
        Produtos Não Vendidos:
Selecione todos os produtos da lista que nunca foram vendidos (ou seja, a QuantidadeVendida é zero em todas as vendas desse produto).
        */

	}
}
/*
ProdutoId (int): Identificador único do produto.
NomeProduto (string): Nome do produto vendido.
Categoria (string): Categoria do produto (ex: Eletrônicos, Utensílios, Alimentos, etc.).
QuantidadeVendida (int): Quantidade de itens vendidos.
PrecoUnitario (decimal): Preço de cada unidade do produto.
DataVenda (DateTime): Data da venda.
*/

class Venda
{
	public int ProdutoId {get;set;}
	public string NomeProduto {get;set;}
	public string Categoria {get;set;}
	public int QuantidadeVendida {get;set;}
	public decimal PrecoUnitario {get;set;}
	public DateTime DataVendas {get;set;}
	
	public Venda(int produtoId, string nomeProduto, string categoria, int quantidadeVendida, decimal precoUnitario, DateTime dataVendas)
	{
		 ProdutoId = produtoId;
		 NomeProduto = nomeProduto;
		 Categoria = categoria; 	
		 QuantidadeVendida = quantidadeVendida;
		 PrecoUnitario = precoUnitario;
		DataVendas = dataVendas;  	
	}
}
