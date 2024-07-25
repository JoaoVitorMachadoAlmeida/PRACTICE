using System;
using System.Globalization;
class HelloWorld {
  static void Main() {
    
    DateTime d1 = DateTime.Now;
    DateTime d2 = new DateTime(2024, 07, 24);
    DateTime d3 = new DateTime(2024,07,24,22,36,4);
    DateTime d4 = new DateTime(2024,07,24,22,36,4,500);
   
    DateTime d5 = DateTime.Today;
    DateTime d6 = DateTime.UtcNow;
    
    DateTime d7 = DateTime.Parse("2000-08-15");
    DateTime d8 = DateTime.Parse("200-08-15 13:05:08");
    DateTime d9 = DateTime.Parse("10/06/2077");
    
    DateTime d10 = DateTime.ParseExact("2000-08-15" , "yyyy-MM-dd", CultureInfo.InvariantCulture);
   
   
    Console.WriteLine(d1.Ticks);
    Console.WriteLine(d2);
    Console.WriteLine(d3);
    Console.WriteLine(d4);
    Console.WriteLine(d5);
    Console.WriteLine(d6);
    Console.WriteLine(d7);
    Console.WriteLine(d8);
    Console.WriteLine(d9);
    Console.WriteLine(d10);
  }
}
