using System;
using System.Collections.Generic;
using System.Globalization;
class Program {
  static void Main() {
    List<TaxPayer> list = new List<TaxPayer>();

      GetInfo(list);
      PrintResult(list);
    }
    public static void GetInfo(List<TaxPayer> list)
    {
        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax payer #{i} data: ");
            Console.Write("Individual or company (i/c)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual Income: ");
            double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(ch == 'i')
            {
                Console.Write("Health Expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Individual(name, anualIncome, healthExpenditures));
            }
            else if(ch == 'c')
            {
                Console.Write("Number of employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine());

                list.Add(new Company(name, anualIncome, numberOfEmployees));
            }
            else
            {
                Console.WriteLine("Invalid input!");
                i--;
                continue;
            }
        }
    }

    public static void PrintResult(List<TaxPayer> list)
    {
        Console.WriteLine("\nTAXES PAID:");
        foreach(TaxPayer tp in list)
        {
            Console.WriteLine(tp.ToString());
        }
        double sum = 0.0;
        foreach(TaxPayer tp in list)
        {
             sum += tp.Tax();
        }

        Console.WriteLine($"\nTOTAL TAXES: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}  
/************************************************************/
abstract class TaxPayer
{
    public string Name { get; set; }
    public double AnualIncome { get; set; }

    public TaxPayer()
    {
    }

    public TaxPayer(string name, double anualIncome)
    {
        Name = name;
        AnualIncome = anualIncome;
    }

    public abstract double Tax();

    public override string ToString()
    {
        return $"{Name}: ${Tax():F2}";
    }
}
/**************************************************************/
class Individual : TaxPayer
{
    public double HealthExpenditures { get; set; }

    public Individual()
    {
    }

    public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
    {
        HealthExpenditures = healthExpenditures;
    }

    public override double Tax()
    {
       if(AnualIncome <= 20000)
        {
            return (AnualIncome * 0.15) - (HealthExpenditures / 2);
        }
        else
        {
            return (AnualIncome * 0.25) - (HealthExpenditures / 2);
        }
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
/**************************************************************/
class Company : TaxPayer
{
    public int NumberOfEmployees { get; set; }

    public Company()
    {
    }

    public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
    {
        NumberOfEmployees = numberOfEmployees;
    }

    public override double Tax()
    {
        if(NumberOfEmployees > 10)
        {
            return AnualIncome * 0.14;
        }
        else
        {
         return AnualIncome * 0.16;   
        }
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
