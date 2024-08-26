using System;
using System.Collections.Generic;

class Program {
  static void Main() 
  {
    List<Payment> list = new List <Payment>();

    list.Add(new CreditCardPayment(100, "1254365"));
    list.Add(new PayPalPayment(100, "jv03146@gmail.com"));
    list.Add(new BankTrasferPayment(100, "123456"));

    foreach(Payment payment in list)
    {
      payment.ProcessPayment();
    }
  }
}
/********************************************************************/
abstract class Payment
{
  public double Amount { get; set; }

  public Payment()
  {
  }

  public Payment(double amount)
  {
    Amount = amount;
  }

  public abstract void ProcessPayment();
}
/********************************************************************/
class CreditCardPayment : Payment
{
  public string CardNumber { get; set; }

  public CreditCardPayment()
  {
  }

  public CreditCardPayment(double amount, string cardNumber) : base(amount)
  {
    CardNumber = cardNumber;
  }

  public override void ProcessPayment()
  {
    Console.WriteLine($"Processing credit card payment of {Amount}");
    Console.WriteLine();
  }
}
/********************************************************************/
class PayPalPayment : Payment
{
  public string Email { get; set; }

  public PayPalPayment()
  {
  }

  public PayPalPayment(double amount, string email) : base(amount)
  {
    Email = email;
  }

  public override void ProcessPayment()
  {
    Console.WriteLine($"Processing PayPal payment of {Amount}");
    Console.WriteLine();
  }
}
/********************************************************************/
class BankTrasferPayment : Payment
{
  public string BankAccount { get; set; }

  public BankTrasferPayment()
  {
  }

  public BankTrasferPayment(double amount, string bankAccount) : base(amount)
  {
    BankAccount = bankAccount;
  }

  public override void ProcessPayment()
  {
    Console.WriteLine($"Processing bank transfer of {Amount}");
    Console.WriteLine();
  }
}
