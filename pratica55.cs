/*
Coleta de Dados: Solicita ao usuário o número de funcionários a serem registrados e os dados de cada um (ID, nome e salário).
Registro dos Funcionários: Armazena os funcionários em uma lista.
Coleta de Dados para Aumento: Solicita o ID do funcionário e a porcentagem de aumento.
Aplicação do Aumento: Encontra o funcionário com o ID fornecido, calcula e aplica o aumento salarial.
Exibição da Lista: Exibe a lista atualizada de funcionários.


classe Funcionarios{
    id
    nome
    salario
    
    public Funcionarios(id,nome,salario){
        Id = id
        Nome = nome
        Salario = salario
    }
    public double Aumento(porcentagem){
        double aumento = Salario * (porcentagem / 100);
        Salario += aumento;
        return Salario;
    }
}



*/
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    List<Funcionarios> funcionarios = new List<Funcionarios>();
    
    Console.Write("Quantos funcionarios serão registrados? ");
    int numeroFuncionarios = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < numeroFuncionarios; i++){
        Console.Write($"Id funcionario {i + 1}: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write($"Nome do funcionario {i + 1}: ");
        string nome = Console.ReadLine();
        Console.Write($"Salário do funcionario {i + 1}: ");
        double salario = double.Parse(Console.ReadLine());
        Console.WriteLine();
        
        funcionarios.Add(new Funcionarios(id, nome, salario));
    }
    
    Console.WriteLine();
    Console.WriteLine("Qual é o id do funcionario que receberá o aumento? ");
    int idAumento = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a porcetagem do aumento: ");
    double porcentagemAumento = double.Parse(Console.ReadLine());
    
    bool encontrado = false;
    foreach(var funcionario in funcionarios){
        if(funcionario.Id == idAumento){
            double novoSalario = funcionario.Aumento(porcentagemAumento);
            Console.WriteLine($"Novo salário de {funcionario.Nome} (ID: {funcionario.Id}): {novoSalario:C2}");
                encontrado = true;
                break;
        }
    }
    if (!encontrado) {
            Console.WriteLine("Nenhum funcionário encontrado com o ID fornecido.");
        }
    Console.WriteLine("Lista atualizada: ");
    foreach(var funcionario in funcionarios){
          Console.WriteLine($"ID: {funcionario.Id}, Nome: {funcionario.Nome}, Salário: {funcionario.Salario}");
    }
    
  }
}
class Funcionarios{
    public int Id{get;set;}
    public string Nome{get;set;}
    public double Salario{get;set;}
    
    public Funcionarios(int id, string nome,double salario ){
        Id = id;
        Nome = nome;
        Salario = salario;
    }
    
    public double Aumento(double porcentagem) {
        double aumento = Salario * (porcentagem / 100);
        Salario += aumento;
        return Salario;
    }
}
