/*
 Sistema de Gerenciamento de Estoque
Desenvolva um sistema simples de gerenciamento de estoque que permita ao usuário adicionar e remover itens de um estoque. O sistema deve lançar exceções personalizadas para condições inválidas.

Instruções:

Crie uma classe Product com propriedades como Name e Quantity.
Crie uma classe Inventory que gerencia uma lista de produtos.
Implemente métodos para adicionar e remover produtos.
Lance uma exceção personalizada ProductNotFoundException quando o usuário tentar remover um produto que não existe no estoque.
Lance uma exceção personalizada InsufficientQuantityException quando o usuário tentar remover mais produtos do que o disponível.
*/
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
       Inventory inventory = new Inventory();

        try{
            inventory.AddProduct(new Product("Caneta", 100));
            inventory.AddProduct(new Product("Caderno", 50));
            inventory.AddProduct(new Product("Borracha", 20));

            inventory.RemoveProduct("Caderno", 30);  
                inventory.RemoveProduct("Caderno", 25);  
                inventory.RemoveProduct("Lápis", 10);
            
        }
        catch(ProductNotFoundException ex)
        {
            Console.WriteLine("Error " + ex.Message);
        }
        catch(InsufficientQuantityException ex)
        {
            Console.WriteLine("Error " + ex.Message);
        }
        
        
    }
}
/****************************************************************************************/
class Inventory
{
    public List<Product> Products { get; set; } = new List<Product>();

    public Inventory()
    {
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public void RemoveProduct(string productName, int quantity)
    {
        Product product = null;

        foreach(Product p in Products)
        {
            if(p.Name == productName)
            {
                product = p;
                break;
            }
        }

        if(product == null)
        {
            throw new ProductNotFoundException($"Produto {productName} não encontrado no estoque");
        }

        if(product.Quantity < quantity)
        {
            throw new InsufficientQuantityException($"Quantidade insuficiente no estoque para o produto '{productName}'. Quantidade disponivel: {product.Quantity}, quantidade solicitada: {quantity}");
        }

        product.Quantity -= quantity;
        Console.WriteLine(product.Name + " removido do estoque com sucesso!");

        if(product.Quantity == 0)
        {
            Products.Remove(product);
        }
    }
}
/****************************************************************************************/
class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public Product()
    {
    }

    public Product(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}
/********************************************************************************************/
public class ProductNotFoundException : ApplicationException
{
    public ProductNotFoundException(string message) : base(message) {}
}

/********************************************************************************************/
public class InsufficientQuantityException : ApplicationException
{
    public InsufficientQuantityException(string message) : base(message) {}
}
