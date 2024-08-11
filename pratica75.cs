/******************************************************************************

Exercício: Sistema de Cadastro de Alunos
Descrição: Crie um programa que gerencie um sistema de cadastro de alunos. Cada aluno deve ter um nome, idade e uma nota final. O programa deve permitir que você adicione alunos, exiba todos os alunos cadastrados, exiba os alunos aprovados (nota >= 7) e calcule a média das notas da turma.

Funcionalidades:
Adicionar Novo Aluno:

Solicite ao usuário o nome, a idade e a nota final do aluno.
Armazene essas informações em uma lista de alunos.
Exibir Todos os Alunos:

Mostre uma lista com o nome, idade e nota final de todos os alunos cadastrados.
Exibir Alunos Aprovados:

Mostre uma lista com o nome, idade e nota final apenas dos alunos aprovados (nota >= 7).
Calcular a Média da Turma:

Calcule e exiba a média das notas de todos os alunos cadastrados.

*******************************************************************************/
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    List<Alunos> alunos = new List<Alunos>();
    while(true){
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1-Adicionar aluno");
    Console.WriteLine("2-Mostrar lista de alunos");
    Console.WriteLine("3-Media das notas");
    Console.WriteLine("4-Fechar programa");
    char escolha = char.Parse(Console.ReadLine());
    
    switch(escolha){
    case '1':
    AdicionarAlunos(alunos);
    break;
    
      }
    }
  }
  public static void AdicionarAlunos(List<Alunos> alunos){
      Console.Write("Quantos alunos deseja adicionar? ");
      int quantAlunos = int.Parse(Console.ReadLine());
      
      for(int i = 0; i < quantAlunos; i++){
          Console.WriteLine($"Aluno {i+1}");
          Console.Write("Nome: ");
          string nome = Console.ReadLine();
          Console.Write("Idade: ");
          int idade = int.Parse(Console.ReadLine());
          Console.Write("Nota: ");
          double nota = double.Parse(Console.ReadLine());
          Console.WriteLine();
          
          alunos.Add(new Alunos(nome,idade,nota));
      }
  }
}
class Alunos{
    public string Nome{get;set;}
    public int Idade{get;set;}
    public double Nota{get;set;}
    
    public Alunos(string nome, int idade, double nota){
        Nome = nome;
        Idade = idade;
        Nota = nota;
    }
}
