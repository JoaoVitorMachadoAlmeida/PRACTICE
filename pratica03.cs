using System;
	namespace CalcularAreaCirculo
{
 class Program
 {
  static void Main(string[] args)
  {
double areaCirculo = 0;
   double RaioDoCirculo = 0;
   Console.WriteLine(" Informe o raio do Círculo : ");
   RaioDoCirculo = Convert.ToDouble(Console.ReadLine());
   areaCirculo = Math.PI * Math.Pow(RaioDoCirculo, 2); //exemplo mostrando Math.PI e Math.Pow
   Console.WriteLine(" A área do círculo de raio " +  RaioDoCirculo.ToString() + " é : " + areaCirculo.ToString());
   Console.ReadKey();
  }
 }
}