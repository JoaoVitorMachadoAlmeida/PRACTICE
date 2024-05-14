using System;
using System.Globalization;
class HelloWorld {
    
    static double Pi = 3.14;
  
  static void Main() {
    Console.WriteLine("Digite o valor do raio");
    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    
    double circ = Circunferencia(raio);
    double vol = Volume(raio);
    
    Console.WriteLine("Circuferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
    Console.WriteLine("Volume: " + vol.ToString("F2",CultureInfo.InvariantCulture));
    Console.WriteLine("Pi: " + Pi.ToString("F2",CultureInfo.InvariantCulture));
    
  }
  
  static double Circunferencia(double r){
      return 2.0 * Pi * r;
  }
  
  static double Volume(double r){
      return 4.0 / 3.0 * Pi * Math.Pow(r,3);
  }
}
