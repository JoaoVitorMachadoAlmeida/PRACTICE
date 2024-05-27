using System;
using System.Globalization;
class HelloWorld {
    
    
  
  static void Main() {
    
    
    Console.Write("Digite o valor do raio: ");
    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    
    double circ = Calculadora.Circunferencia(raio);
    double vol = Calculadora.Volume(raio);
    
    Console.WriteLine("Circuferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
    Console.WriteLine("Volume: " + vol.ToString("F2",CultureInfo.InvariantCulture));
    Console.WriteLine("Pi: " + Calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));
    
  }
  
 
}
public class Calculadora{
     public static double Pi = 3.14;
    
      public static double Circunferencia(double r){
      return 2.0 * Pi * r;
  }
  
  public static double Volume(double r){
      return 4.0 / 3.0 * Pi * Math.Pow(r,3);
  }
}
