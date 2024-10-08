using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main()
    {
      Console.Write("Enter department's name: ");
      string deptName = Console.ReadLine();
      Console.WriteLine("Enter Worker data: ");
      Console.Write("Name: ");
      string name = Console.ReadLine();
      Console.Write("Level (Junior/MidLevel/Senior): ");
      WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
      Console.Write("Base salary: ");
      double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Department dept = new Department(deptName);
      Worker worker = new Worker(name, level, baseSalary,dept);

      Console.Write("How many contracts to this worker? ");
      int n = int.Parse(Console.ReadLine());

      for(int i = 1; i<=n; i++)
      {
        Console.WriteLine($"Enter #{i} contract data");
        Console.Write("Date (DD/MM/YYYY): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Duration (hours): ");
        int hours = int.Parse(Console.ReadLine());
        HourContract contract = new HourContract(date, valuePerHour, hours);
        worker.AddContract(contract);
      }

      Console.WriteLine();
      Console.Write("Enter month and year to calculate income (MM/YYYY): ");
      string monthAndYear = Console.ReadLine();
      int month = int.Parse(monthAndYear.Substring(0,2));
      int year = int.Parse(monthAndYear.Substring(3));
      Console.WriteLine("Name: "+worker.Name);
      Console.WriteLine("Department: "+worker.Department.Name);
      Console.WriteLine("Income for: "+ monthAndYear + ": " + worker.Income(year,month).ToString("F2", CultureInfo.InvariantCulture));
      
      
    }
}
/******************************************************************************/
class Department
{
    public string Name { get; set; }

    public Department()
    {
    }

    public Department(string name)
    {
        Name = name;
    }
}
/******************************************************************************/
class HourContract
{
    public DateTime Date { get; set; }
    public double ValuePerHour { get; set; }
    public int Hours { get; set; }

    public HourContract()
    {
    }

    public HourContract(DateTime date, double valuePerHour, int hours)
    {
        Date = date;
        ValuePerHour = valuePerHour;
        Hours = hours;
    }

    public double TotalValue()
    {
        return Hours * ValuePerHour;
    }
}
/******************************************************************************/
class Worker
{
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }
    public Department Department { get; set; }
    public List<HourContract> Contracts { get; set; } = new List<HourContract>();

    public Worker()
    {
    }

    public Worker(string name, WorkerLevel level, double baseSalary, Department department)
    {
        Name = name;
        Level = level;
        BaseSalary = baseSalary;
        Department = department;
    }

    public void AddContract(HourContract contract)
    {
        Contracts.Add(contract);
    }

    public void RemoveContract(HourContract contract)
    {
        Contracts.Remove(contract);
    }

    public double Income(int year, int month)
    {
        double sum = BaseSalary;
        foreach (HourContract contract in Contracts)
        {
            if (contract.Date.Year == year && contract.Date.Month == month)
            {
                sum += contract.TotalValue();
            }
        }
        return sum;
    }

}
/******************************************************************************/
enum WorkerLevel : int
{
    Junior = 0,
    MidLevel = 1,
    Senior = 2

}
