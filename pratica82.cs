using System;
class HelloWorld {
  static void Main() 
  {
    BusinessAccount account = new BusinessAccount(8010,"Bob brown",100,500);
    
    Console.WriteLine(account.Balance);
    
    //account.Balance = 200;
  }
}
/*********************************************************/
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
    
    public void WithDraw(double amount)
    {
        Balance -= amount;
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
    
