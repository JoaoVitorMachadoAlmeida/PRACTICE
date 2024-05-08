using System;
class Construtores{
    public string nome;
    public double salario;
}
class HelloWorld {
  static void Main() {
    Construtores c1, c2;
    c1 = new Construtores();
    c2 = new Construtores();
    Console.WriteLine("Digite o nome do primeiro funcionario: ");
    c1.nome = Console.ReadLine();
    Console.WriteLine("Digite o seu sálario: ");
    c1.salario = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o nome do segundo funcionario: ");
    c2.nome = Console.ReadLine();
    Console.WriteLine("Digite o seu sálario: ");
    c2.salario = double.Parse(Console.ReadLine());
    
    double media = (c1.salario + c2.salario) / 2;
    Console.Clear();
    Console.WriteLine("A média dos salarios é: {0}",media);
  }
}