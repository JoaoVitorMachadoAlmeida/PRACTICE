using System;
using System.Globalization;

class Program {
  static void Main() 
  {
    Account acc1 = new Account(1001, "Alex",500);
    Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);

    acc1.WithDraw(10);
    acc2.WithDraw(10);

    Console.WriteLine(acc1.Balance);
    Console.WriteLine(acc2.Balance);
  }
}
/********************************************************/
class Account
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
