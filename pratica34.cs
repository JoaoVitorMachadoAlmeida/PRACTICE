using System;
using System.Globalization;
class HelloWorld {
  static void Main() {
    ContaBancaria cb = new ContaBancaria(0000, "Sem nome", 00.00);
    Console.Write("Entre com o seu numero da conta:");
    cb.Conta = int.Parse(Console.ReadLine());
    Console.Write("Entre com o titular da conta:");
    cb.Nome = Console.ReadLine();
    Console.Write("Haverá deposito inicial (S/N)?");
    char escolha = char.Parse(Console.ReadLine().ToUpper());
    switch (escolha){
        case 'S':
        Console.WriteLine();
        Console.Write("Entre com o valor de depósito inicial:");
        cb.Saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Dados da conta:\n{0}",cb.Info());
        break;
        case 'N':
        Console.WriteLine();
        Console.WriteLine("Dados da conta:\n{0}",cb.Info());
        break;
        default:
        Console.WriteLine("Escolha inválida");
        break;
    }
    Console.WriteLine();
    Console.Write("Entre com o valor para depósito:");
    double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    cb.Deposito(deposito);
    Console.WriteLine("Dados atualizado:\n{0}",cb.Info());
    Console.WriteLine();
    Console.Write("Entre com o valor para o saque:");
    double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    cb.Saque(saque);
    Console.WriteLine("Dados atualizados:\n{0}",cb.Info());
    
    
  }
}
class ContaBancaria{
    public int Conta{get; set;}
    public string Nome{get; set;}
    public double Saldo{get; set;}
    
    public ContaBancaria(int conta, string nome, double saldo){
        Conta = conta;
        Nome = nome;
        Saldo = saldo;
    }
    public string Info(){
        return string.Format("Conta {0}, Titular: {1}, Saldo: {2:c}",Conta, Nome, Saldo);
    }
    public double Deposito(double deposito){
        return Saldo = Saldo + deposito;
        
    }
    public double Saque(double saque){
        return Saldo = Saldo - saque;
    }
    
}
