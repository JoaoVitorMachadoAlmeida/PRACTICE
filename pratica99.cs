/*
Desenvolva um sistema de gerenciamento de pedidos para um restaurante. O sistema deve permitir que um cliente faça pedidos, adicione itens ao pedido e calcule o valor total do pedido. Se um item não estiver disponível no cardápio, deve ser lançada uma exceção personalizada.

Instruções:

Classe MenuItem: Deve conter propriedades como Name, Price, e Available.
Classe Order: Deve gerenciar uma lista de itens de pedido (OrderItem), cada um referenciando um MenuItem.
Implemente métodos para adicionar itens ao pedido.
Implemente um método para calcular o valor total do pedido.
Exceções Personalizadas:
ItemNotAvailableException: Lançada quando um item que não está disponível é adicionado ao pedido.
OrderLimitExceededException: Lançada quando o valor total do pedido excede um limite predefinido (ex.: R$ 500).
Regras de Negócio:
Um item pode ser adicionado ao pedido somente se estiver disponível.
O sistema deve calcular o total do pedido e lançar uma exceção se o total exceder um certo limite.
*/
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        
    }
}
/**********************************************************/
class Order
{
    public int OrderID { get; set; }
    public List<MenuItem> MenuItem { get; set; } = new List <MenuItem>();

    public Order()
    {
    }

    public Order(int orderID, List<MenuItem> menuItems)
    {
        OrderID = orderID;
        MenuItem = menuItems;
    }

    public void AddItem(MenuItem menuItem)
    {
        if(menuItem.Available == false)
        {
            throw new ItemNotAvailableException($"\nItem {menuItem.Name} it's not avaible.");
        }
        if(menuItem.Price > 500)
        {
            throw new OrderLimitExceededException($"\nOrder value is over the limit. The order limit is R$ 500.");
        }
    }
}
/**********************************************************/
class MenuItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Available { get; set; }

    public MenuItem(string name, decimal price, bool available)
    {
        Name = name;
        Price = price;
        Available = available;
    }
}
/**********************************************************/
public class ItemNotAvailableException : ApplicationException
{
    public ItemNotAvailableException(string message) : base(message){}
}
/**********************************************************/
public class OrderLimitExceededException : ApplicationException
{
    public OrderLimitExceededException(string message) : base(message){}
}
