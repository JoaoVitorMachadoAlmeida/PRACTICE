/*
Exercício 2: Criar uma Classe ContaBancaria
Objetivo: Implementar uma classe ContaBancaria com propriedades para o saldo, com controle sobre depósitos e saques.

Tarefas:

Crie uma classe ContaBancaria com uma propriedade Saldo.
Saldo deve ser uma propriedade somente leitura.
Adicione métodos Depositar e Sacar para manipular o saldo.
Valide o saque para que não possa ser maior que o saldo disponível.
*/
using System;
class HelloWorld {
  static void Main() {
    ContaBancaria cb = new ContaBancaria(1000);
    cb.Saldo = 10000;
    
    Console.WriteLine("Você tem {0}, deseja depositar ou sacar?\nSacar|A| Depositar|B| Sair|C|",cb.Saldo);
    char escolha = char.Parse(Console.ReadLine().ToUpper());
    switch(escolha){
        case 'A':
        Console.WriteLine("Quanto deseja sacar?");
        double quantidade = double.Parse(Console.ReadLine());
        if(quantidade > 0 && quantidade <= cb.Saldo) 
        Console.WriteLine("O seu saldo agora é de :{0}",cb.Sacar(quantidade));
        else
         Console.WriteLine("Não foi possivel sacar, a quantidade tem que ser maior que 0 ou menor que seu saldo atual");
        break;
        case 'B':
        Console.WriteLine("Quanto deseja depositar?");
        quantidade = double.Parse(Console.ReadLine());
        if(quantidade > 0)
        Console.WriteLine("O seu saldo agora é de :{0}",cb.Depositar(quantidade));
        else
        Console.WriteLine("Você não pode depositar valores menores ou igual a 0");
        break;
        case 'C':
        Console.WriteLine("Saindo...");
        break;
        default:
        Console.WriteLine("Opção inválida");
        break;
        
    }
    
  }
}
class ContaBancaria{
    public double Saldo{get; private set;}
    
    public ContaBancaria(double saldo){
        Saldo = saldo;
    }
    
    public double Depositar(double quantidade){
        
        return Saldo = Saldo + quantidade; 
        
    }
    public double Sacar(double quantidade){

        return Saldo = Saldo - quantidade;
        
    }
}
