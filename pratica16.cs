using System;
class HelloWorld {
  static void Main()
  {
    Console.WriteLine("Digite seu nome: ");
    string nome = Console.ReadLine();
     Console.WriteLine("Digite 3 numeros para sua média(separados por espaço):");
    string [] valores = Console.ReadLine().Split();
    double n1 = double.Parse(valores[0]);
    double n2 = double.Parse(valores[1]);
    double n3 = double.Parse(valores[2]);
    
    
     
     
     Console.ReadKey();
     Console.Clear();
     saudacao(nome);
     media(n1,n2,n3);
  }
  static void saudacao(string name)
  {
  Console.WriteLine("Olá {0}, prazer em conhecer!!",name);
  return;
  }
  static void media(double number1, double number2, double number3)
  {
   double resultado = (number3 + number2 + number1) / 3;
   Console.WriteLine("A media dos numeros {0}, {1} e {2} é de {3:F2}",number1,number2,number3,resultado);
   return;
  }
}