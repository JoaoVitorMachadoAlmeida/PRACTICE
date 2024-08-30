using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Account account = new Account();

        GetValues(ref account);
        ValidationAndShow(ref account);
        
        
    }

    public static void GetValues(ref Account account)
    {
        for(int i = 1; i < 2; i++)
        {
            try{
            Console.WriteLine("Enter Account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());
            Console.WriteLine();    

            account = new Account(number, holder, balance, withdrawLimit);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid format");
                i--;
            }
        }
        
    }
    public static void ValidationAndShow(ref Account account)
    {
        try{
        Console.Write("Enter the amount to withdraw: ");
        double amount = double.Parse(Console.ReadLine());    

        account.Withdraw(amount);

        Console.WriteLine("New balance: " + account.Balance);    
        }
        catch(WithdrawLimitException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(NotEnoughBalanceException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format");
        }
    }
}
/**********************************************************/
class Account
{
    public int AccountNumber { get; set; }
    public string AccountHolder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account()
    {
    }

    public Account(int accountNumber, string accountHolder, double balance, double withdrawLimit)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
        WithdrawLimit= withdrawLimit;
    }

    public void Withdraw(double amount)
    {
        if(amount > Balance)
        {
            throw new NotEnoughBalanceException($"Insufficient balance. Current balance is {Balance}");

        }
        if(amount > WithdrawLimit)
        {
            throw new WithdrawLimitException($"Withdraw limit exceeded. Maximum amount allowed is {WithdrawLimit}");
        }
            Balance -= amount;
    }
    public void Deposit(double amount)
    {
        Balance += amount;
    }
}
/**********************************************************************************/
public class WithdrawLimitException : ApplicationException
{
    public WithdrawLimitException(string message) : base(message){}
}
/**********************************************************************************/
public class NotEnoughBalanceException : ApplicationException
{
    public NotEnoughBalanceException(string message) : base(message){}
}
