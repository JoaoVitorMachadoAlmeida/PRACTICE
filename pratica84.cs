using System;

class HelloWorld {
  static void Main() 
  {
    Account acc = new Account (1001, "Alex", 0);
    BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);
    
    //UpCasting
    
    Account acc1 = bacc;
    Account acc2 = new BusinessAccount (1003, "Bob", 0, 200);
    Account acc3 = new SavingsAccount (1004, "Anna", 0, 0.01);
    
    //DownCasting
    
    BusinessAccount acc4 = (BusinessAccount)acc2;
    acc4.Loan(100);
    
   // BusinessAccount acc5 = (BusinessAccount)acc3;
   if(acc3 is BusinessAccount)
   {
       //BusinessAccount acc5 = (BusinessAccount)acc3;
       BusinessAccount acc5 = acc3 as BusinessAccount; //Sintaxe alternativa
       acc5.Loan(200);
       Console.WriteLine("Loan!");
   }
   if (acc3 is SavingsAccount)
   {
       SavingsAccount acc5 = (SavingsAccount)acc3;
       acc5.UpdateBalance();
       Console.WriteLine("Update!");
   }
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
}
