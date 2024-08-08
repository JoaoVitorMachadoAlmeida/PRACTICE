using System;
class HelloWorld {
  static void Main() {
    DateTime d1 = new DateTime(2000, 8, 8, 13, 5, 58, DateTimeKind.Local);
    
    DateTime d2 = new DateTime(2000, 8, 8, 13, 5, 58, DateTimeKind.Utc);
    
    DateTime d3 = new DateTime(2000, 8, 8, 13, 5, 58);
    
    Console.WriteLine("d1: " + d1);
    Console.WriteLine("d1 Kind: " + d1.Kind);
    Console.WriteLine("d1 ToLocal: " + d1.ToLocalTime());
    Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
    
    Console.WriteLine();
    
    Console.WriteLine("d2: " + d2);
    Console.WriteLine("d2 Kind: " + d2.Kind);
    Console.WriteLine("d2 ToLocal: " + d2.ToLocalTime());
    Console.WriteLine("d2to Utc: " + d2.ToUniversalTime());
    
    Console.WriteLine();
    
    Console.WriteLine("d3: " + d3);
    Console.WriteLine("d3 Kind: " + d3.Kind);
    Console.WriteLine("d3 ToLocal: " + d3.ToLocalTime());
    Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
  }
}
