/*
Exercício 2: Contagem e Soma de Produtos
Você tem uma lista de produtos, cada um com Nome, Categoria, e Preço. Realize as operações abaixo:

Conte quantos produtos estão na categoria "Eletrônicos".
Calcule o total dos preços dos produtos da categoria "Eletrônicos".
Liste os três produtos mais caros.

*/

using System;
using System.Collections.Generic;
using System.Linq;
class HelloWorld {
  static void Main() {
   var products = new List<Products>()
   {
       new Products("TV", "Eletrônicos", 2800),
       new Products("Lampâda", "Eletrônicos", 12),
       new Products("Chuveiro", "Eletrônicos", 400),
       new Products("Radio", "Eletrônicos", 100),
       new Products("Garfo", "Utencílios", 5),
       new Products("Faca", "Utencílios", 7),
       new Products("Colher", "Utencílios", 4),
       new Products("Ceramica", "Itens de casa", 50),
       new Products("Porta", "Itens de casa", 800),
       new Products("Maçaneta", "Itens de casa", 20),
       
   };
   
   Console.Write("Eletronic products: ");
   var eletronicCount = products
   .Count(x => x.Category == "Eletrônicos");
   Console.Write(eletronicCount + "\n");
   Console.WriteLine();
   /****************/
   Console.Write("Total eletronic products price: ");
   var eletronicSum = products
   .Where(x => x.Category == "Eletrônicos")
   .Sum(x => x.Price);
   Console.Write($"{eletronicSum:F2}$\n");
   Console.WriteLine();
   /****************/
   Console.WriteLine("Top 3 products most expensive: ");
   var productsExpensive = products
   .OrderByDescending(x => x.Price)
   .Take(3)
   .ToList();
   foreach(var item in productsExpensive)
   {
       Console.WriteLine(item);
   }
  }
}
class Products
{
    public string Name {get;set;}
    public string Category {get;set;}
    public double Price {get;set;}
    
    public Products(string name, string category, double price)
    {
        Name = name;
        Category = category;
        Price = price;
    }
    
    public override string ToString() =>
        $"Name: {Name} | Category: {Category} | Price: {Price:F2}";
}
