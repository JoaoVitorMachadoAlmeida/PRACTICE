using System;
public class Pessoa{
    public string nome;
    public int idade;
}
public class HelloWorld {
  static void Main() {
    Pessoa p1,p2;
    p1 = new Pessoa();
    p2 = new Pessoa();
    
    Console.WriteLine("Digite o nome da primeira pessoa: ");
    p1.nome = Console.ReadLine();
    Console.WriteLine("Digite sua idade: ");
    p1.idade = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o nome da segunda pessoa: ");
    p2.nome = Console.ReadLine();
    Console.WriteLine("Digite sua idade: ");
    p2.idade = int.Parse(Console.ReadLine());
    if(p1.idade > p2.idade){
        Console.WriteLine("A pessoa mais velha é: {0}",p1.nome);
    }else{
        Console.WriteLine("A pessoa mais velha é: {0}",p2.nome);
    }
  }
}