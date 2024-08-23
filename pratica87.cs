using System;
using System.Globalization;
using System.Collections.Generic;

class Program {
  static void Main() 
  {
    List<Account> list = new List<Account>();

    list.Add(new SavingsAccount(1001,"Alex", 500.0, 0.01));
    list.Add(new BusinessAccount(1002,"Maria", 500.0, 400.0));
    list.Add(new SavingsAccount(1003,"Bob", 500.0, 0.01));
    list.Add(new BusinessAccount(1004,"Anna", 500.0, 500.0));

    double sum = 0;
    foreach(Account acc in list)
    {
      sum += acc.Balance;
    }
    
    Console.WriteLine("Total balance: "+ sum.ToString("F2", CultureInfo.InvariantCulture));

    foreach(Account acc in list)
    {
      acc.WithDraw(10.0);
    }

    foreach(Account acc in list)
    {
      Console.WriteLine("Update balance for account " + acc.Number + ": " + acc.Balance.ToString("F2",CultureInfo.InvariantCulture));
    }
  }
}
/********************************************************/
abstract class Account
{
    public int Number{get; private set;}
    public string Holder {get; private set;}
    public double Balance {get; protected set;}

    public Account()
    {
    }

    public Account(int number, string holder, double balance)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
    }

    public virtual void WithDraw(double amount)
    {
        Balance -= amount + 5;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}
/************************************************************/
class BusinessAccount : Account
{
  public double LoanLimit{get;set;}  

  public BusinessAccount()
  {
  }

  public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
  {
    LoanLimit = loanLimit;  
  }

  public void Loan(double amount)
  {
    if (amount <= LoanLimit)
    Balance += amount;
  }
}
/************************************************************/
class SavingsAccount : Account
{
    public double InterestRate{get;set;}

    public SavingsAccount()
    {
    }

    public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
    {
       InterestRate = interestRate; 
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }

  public override void WithDraw(double amount)
  {
    base.WithDraw(amount); // vai herdar da superclasse a taxa de 5
    Balance -= 2; //vai deascontar mais dois ainda, ent a taxa passa a ser 7
  }
}
