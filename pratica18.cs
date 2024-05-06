
using System;
class Triangulo{
    public double A;
    public double B;
    public double C;
}
class HelloWorld {
  static void Main() {
      Triangulo x = new Triangulo();
      Triangulo y = new Triangulo();
      
    Console.WriteLine("Entre com a medida do trinagulo x:");
     x.A = double.Parse(Console.ReadLine());
     x.B = double.Parse(Console.ReadLine());
     x.C = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Entre com a medida do triangulo y:");
     y.A = double.Parse(Console.ReadLine());
     y.B = double.Parse(Console.ReadLine());
     y.C = double.Parse(Console.ReadLine());
    
    double p = (x.A + x.B + x.C) / 2;
     double areaX = Math.Sqrt(p*(p - x.A) * (p - x.B) * (p - x.C));
    
    p = (y.A + y.B + y.C) / 2;
    double areaY = Math.Sqrt(p*(p - y.A) * (p - y.B) * (p - y.C));
    
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