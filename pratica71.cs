using System;
class HelloWorld {
  static void Main() {
    DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
    
    Console.WriteLine(d);
    Console.WriteLine("1) Date: " + d.Date);
    Console.WriteLine("2) Day: " + d.Day);
    Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
    Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
    Console.WriteLine("5) Hour: " + d.Hour);
    Console.WriteLine("6) Kind: " + d.Kind);
    Console.WriteLine("7) Millisecond: " + d.Millisecond);
    Console.WriteLine("8) Minute: " + d.Minute);
    Console.WriteLine("9) Month: " + d.Month);
    Console.WriteLine("10) Second: " + d.Second);
    Console.WriteLine("11) Ticks: " + d.Ticks);
    Console.WriteLine("12)TimeOfDay: " + d.TimeOfDay);
    Console.WriteLine("13) Year: " + d.Year);
    
    
    
    string s1 = d.ToLongTimeString();
    string s2 = d.ToShortDateString();
    string s3 = d.ToShortTimeString();
    
    string s4 = d.ToString();
    
    string s5 = d.ToString("yyyy-MM-dd HH:mm:ss");
    string s6 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
    
    Console.WriteLine(d.ToLongDateString());
    Console.WriteLine(s1);
    Console.WriteLine(s2);
    Console.WriteLine(s3);
    Console.WriteLine(s4);
    Console.WriteLine(s5);
    Console.WriteLine(s6);
    
    
    DateTime d2 = d.AddHours(2);
    
    DateTime d3 = d.AddMinutes(23);
    
    Console.WriteLine(d2);
    Console.WriteLine(d3);
    
  }
}
