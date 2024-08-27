using System;
using System.Collections.Generic;
using System.Globalization;
class Program {
  static void Main() {
    List<Shape> list = new List<Shape>();

      GetInfo(list);
      PrintInfo(list);
      
    }
    public static void GetInfo(List<Shape> list)
    {
        Console.Write("Enter with the number of shapes: ");
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 1; i <= n; i ++)
        {
            Console.WriteLine($"Shape #{i} data: ");
            Console.Write("Rectangle or Circle (r/c): ");
            char shape = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Color (Black, Blue or Red): ");
            string colorInput = Console.ReadLine();
            
            if(Enum.TryParse(colorInput, true, out Color color))
            {
            if (shape == 'r')
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Rectangle(color, width, height));
            }
                else if (shape == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, radius));
                }
                else
                {
                    Console.WriteLine("Invalid shape type.");
             }
          }
        }
    }
    public static void PrintInfo(List<Shape> list)
    {
        Console.WriteLine("\nSHAPE AREAS:");
        foreach(Shape shape in list)
        {
            Console.WriteLine(shape.ToString());
        }
    }
}    
/********************************************************/  
enum Color
{
    Black,
    Blue,
    Red
}
/********************************************************/
abstract class Shape
{
    public Color Color { get; set; }

    public Shape()
    {
    }

    public Shape(Color color)
    {
        Color = color;
    }

     public abstract double Area();

    public override string ToString()
    {
        return $"{Area():F2}";
    }
}
/**********************************************************/
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle()
    {
    }

    public Rectangle(Color color, double width, double height) : base(color)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }

    public override string ToString()
    {
      return base.ToString();
    }
}
/**********************************************************/
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle()
    {
    }

    public Circle (Color color, double radius) : base(color)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
