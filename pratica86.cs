using System;
using System.Collections.Generic;
using System.Globalization;

class Program {
  static void Main() 
  {
    List<Product> products = GetProducts();
    PrintProducts(products);
    
    
  }
  static List<Product> GetProducts()
  {
    List<Product> list = new List<Product>();

    Console.Write("Enter the number of products: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
      Console.WriteLine("Product #" + i + " data:");
      Console.Write("Common, used or imported (c/u/i)? ");
      char ch = char.Parse(Console.ReadLine());

      Console.Write("Name: ");
      string name = Console.ReadLine();
      Console.Write("Price: ");
      double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      if (ch == 'c')
      {
        list.Add(new Product(name, price));
      }
      else if (ch == 'u')
      {
        Console.Write("Manufacture date (dd/MM/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        
        list.Add(new UsedProduct(name, price, date));
      }
      else if (ch == 'i')
      {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new ImportedProduct(name, price, customsFee));
      }
      else
      {
        Console.WriteLine("Invalid product type!");
      }
    }
    return list;
  }
  static void PrintProducts(List<Product> list)
  {
    Console.WriteLine();
    Console.WriteLine("PRICE LIST");
    foreach(Product p in list)
    {
      Console.WriteLine(p.PriceTag(),CultureInfo.InvariantCulture);
    }
  }
}
/********************************************************/
class Product
{
  public string Name {get;set;}
  public double Price {get;set;}

  public Product()
  {
  }

  public Product(string name, double price)
  {
    Name = name;
    Price = price;
  }

  public virtual string PriceTag()
  {
    return $"{Name} {Price:C}";
  }
}
/**********************************************************/
class ImportedProduct : Product
{
  public double CustomsFee {get;set;}

  public ImportedProduct()
  {
  }

  public ImportedProduct(string name, double price, double customsFee) : base(name, price)
  {
    CustomsFee = customsFee;
  }
  public double TotalPrice()
  {
    return Price + CustomsFee;
  }
  public override string PriceTag()
  {
    return $"{Name} {TotalPrice():C} (Customs Fee: {CustomsFee:C})";
  }
}
/**********************************************************/
class UsedProduct : Product
{
  public DateTime ManufactureDate {get;set;}

  public UsedProduct()
  {
  }

  public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
  {
    ManufactureDate = manufactureDate;
  }
  public override string PriceTag()
  {
    return $"{Name} (used) {Price:C} (Manufacure Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
  }
}


