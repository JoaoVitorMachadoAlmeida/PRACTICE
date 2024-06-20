using System;
class HelloWorld {
  static void Main() {
    
    Point p;
    p.X = 10;
    p.Y = 20;
    Console.WriteLine(p);
    
  }
}
struct Point{
    
    public double X;
    public double Y;
    
    public override string ToString(){
        return"(" + X + "," + Y + ")";
    } 
    
}
