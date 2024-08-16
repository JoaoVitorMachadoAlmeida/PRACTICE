/*
Exercício 1: Sistema de Pedidos
Crie um sistema simples de gerenciamento de pedidos para uma loja online. Cada Pedido deve ter um cliente associado, bem como uma lista de ItensPedido.

Classes Sugeridas:
Cliente: Contém informações como Nome, Email, Endereço.
ItemPedido: Contém informações como Produto, Quantidade, Preco.
Pedido: Contém informações como Cliente, Data, Itens (uma lista de ItemPedido).
Funcionalidade:
O sistema deve permitir adicionar itens a um pedido e calcular o total do pedido.
Implemente métodos para adicionar itens ao pedido e calcular o valor total.
*/
using System;
using System.Collections.Generic;
using System.Globalization;

class Program 
{
  public static void Main (string[] args) 
  {
    Client client = new Client("João Vitor", "jv03146@gmail", "Rua Imbé, Jardim das Rosas, Nº 150");

    Order order = new Order(client, DateTime.Now);
    
    OrderItem orderItem1 = new OrderItem("Camiseta", 10, 20.0);
    OrderItem orderItem2 = new OrderItem("Calça", 6, 50.0);

    order.AddItem(orderItem1);
    order.AddItem(orderItem2);

    double total = order.CalculateTotal();
    Console.WriteLine("Total do pedido: " + total.ToString("F2",CultureInfo.InvariantCulture));

    
  }
}
/**********************************************************/
class Client
{
  public string Name {get;set;}
  public string Email {get;set;}
  public string Adress {get;set;}

  public Client()
  { 
  }
public Client(string name, string email, string adress)
  {
    Name = name;
    Email = email;
    Adress = adress;
  }
}
/**********************************************************/
class Order
{
  public Client Client {get;set;}
  public DateTime Date {get;set;}
  public List<OrderItem> OrderItems {get;set;} = new List<OrderItem>();

  public Order()
  {
  }

  public Order(Client client, DateTime date)
  {
    Client = client;
    Date = date;
    
  }

  public void AddItem(OrderItem item)
  {
   OrderItems.Add(item);
  }
  public void RemoveItem(OrderItem item)
  {
  OrderItems.Remove(item);
  }
  public double CalculateTotal()
  {
    double total = 0.0;

    foreach(var item in OrderItems)
    {
      total += item.Ammount * item.Price;
    }
    return total;
  }
}
/**********************************************************/
class OrderItem
{
  public string Product {get;set;}
  public int Ammount {get;set;}
  public double Price {get;set;}

  public OrderItem()
  {
  }

  public OrderItem(string product, int ammount, double price)
  {
    Product = product;
    Ammount = ammount;
    Price = price;
  }
}
