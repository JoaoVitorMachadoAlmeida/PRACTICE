using System;
using System.Collections.Generic;

class Program {
  static void Main() 
  {
    List<OrderItem> list = new List<OrderItem>();

    list.Add(new DigitalProduct("PS4", 1, 2800, "https://www.americanas.com.br/categoria/games/playstation-4/console-ps4"));
    list.Add(new PhysicalProduct("Mug", 6, 15.99m, 2));
    list.Add(new Service("Engineer", 1, 305.76m, 3));

    foreach(OrderItem item in list)
    {
      Console.WriteLine(item);
    }
  }
}
/********************************************************************/
class OrderItem
{
  public string Product { get; set; }
  public int Quantity { get; set; }
  public decimal Price { get; set; }

  public OrderItem()
  {
  }

  public OrderItem(string product, int quantity, decimal price)
  {
    Product = product;
    Quantity = quantity;
    Price = price;
  }
  public virtual decimal GetTotal()
  {
    return Quantity * Price;
  }
  public override string ToString()
  {
    return $"{Product} {Quantity} {Price} {GetTotal()}";
  }
}
/********************************************************************/
class DigitalProduct : OrderItem
{
  public string DowloadLink { get; set; }

  public DigitalProduct()
  {
  }

  public DigitalProduct(string product, int quantity, decimal price, string dowloadLink) : base(product, quantity, price)
  {
    DowloadLink = dowloadLink;
  }
  public override decimal GetTotal()
  {
    double discount = (double)(Quantity * Price) * 0.1 ;
    return Quantity * Price - (decimal)discount;
  }
  public override string ToString()
  {
    return $"Product: {Product} \nQuantity: {Quantity} \nUnit price: {Price} \nTotal Price:{GetTotal():C} \nLink: {DowloadLink}\n";
  }
}
/********************************************************************/
class PhysicalProduct : OrderItem
{
  public double Weight { get; set; }

  public PhysicalProduct()
  {
  }

  public PhysicalProduct(string product, int quantity, decimal price, double weight) : base(product, quantity, price)
  {
    Weight = weight;
  }
  public override decimal GetTotal()
  {
    double shipper = (double)(Weight * 5);
    return Quantity * Price + (decimal)shipper;
  }
  public override string ToString()
  {
    return $"Product: {Product} \nQuantity: {Quantity} \nUnit price: {Price} \nWeight: {Weight}KG ($5 per kilogram)\nTotal Price:{GetTotal():C}\n";
  }
}
/********************************************************************/
class Service : OrderItem
{
  public int ServiceHours { get; set; }

  public Service()
  {
  }

  public Service(string product, int quantity, decimal price, int serviceHours) : base(product, quantity, price)
  {
    ServiceHours = serviceHours;
  }
  public override decimal GetTotal()
  {
    double totalService = (double)(ServiceHours * 10);
    return Quantity * Price + (decimal)totalService;
  }
  public override string ToString()
  {
    return $"Product: {Product} \nQuantity: {Quantity} \nUnit price: {Price} \nService Hours: {ServiceHours}H ($10 per hour)\nTotalPrice:{GetTotal():C}\n ";
  }
}
