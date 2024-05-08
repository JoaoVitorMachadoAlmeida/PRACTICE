using System;
using System.Globalization;
class Triangulo{
    public double A;
    public double B;
    public double C;
    
    public double Area(){
    
    double p = (A + B + C) / 2;
     return Math.Sqrt(p*(p - A) * (p - B) * (p - C));
    
    }
}
class HelloWorld {
  static void Main() {
      Triangulo x = new Triangulo();
      Triangulo y = new Triangulo();
      
    Console.WriteLine("Entre com a medida do trinagulo x:");
     x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
     x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
     x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    
    Console.WriteLine("Entre com a medida do triangulo y:");
     y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
     y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
     y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    
    
    double areaX = x.Area();
    
    double areaY = y.Area();
    
    Console.WriteLine("Área de x = {0:F4}",areaX);
    Console.WriteLine("Área de y = {0:F4}",areaY);
    
    if(areaX > areaY){
     Console.WriteLine("Maior área: X");  
    }else if(areaX < areaY){
        Console.WriteLine("Maior área: Y");
    }else{
       Console.WriteLine("As áreas são iguais");
    }
  }
}
