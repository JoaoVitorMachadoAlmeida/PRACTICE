/******************************************************************************

Crie uma lista de doubles que armazena notas de alunos.
Calcule a média das notas e exiba as notas acima da média.


Entrada: pedir para escolher quantos alunos irão serão avaliados para a média / percorrer cada nota de aluno e no final adicionar no Add();
Saida(As notas de todos os alunos e embaixo a media das notas)
*******************************************************************************/
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    List<Alunos> alunos = new List<Alunos>();
    
    Console.Write("Quantas notas serão avaliados? ");
    int quantNotas = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < quantNotas; i++){
    Console.Write($"Aluno #{i + 1}: ");
    string nome = Console.ReadLine();
    
    Console.Write("Nota do aluno: ");
    double notas = double.Parse(Console.ReadLine());
    
    Console.WriteLine();
    
    alunos.Add(new Alunos(nome,notas));
        }
       CalculadoraMedias calculadora = new CalculadoraMedias(); 
       double media = calculadora.CalculoMedias(alunos);
       Console.WriteLine($"Media das notas: {media:F2}");
       Console.ReadKey();
       Console.WriteLine();
       
       Console.WriteLine("Alunos acima da média: ");
      calculadora.AlunosAcimaDaMedia(alunos, media);
        
    }
}
class Alunos{
    public string Nome{get;set;}
    public double Notas{get;set;}
    
    public Alunos(string nome, double notas){
        Nome = nome;
        Notas = notas;
    }
}
class CalculadoraMedias{
    public double CalculoMedias(List<Alunos> alunos){
        double soma = 0;
        
        foreach(var aluno in alunos){
            soma += aluno.Notas;
        }
        
        return soma / alunos.Count;
    }
    
    public void AlunosAcimaDaMedia(List<Alunos>alunos, double media){
        
            foreach(var aluno in alunos){
                if(aluno.Notas > media){
                    Console.WriteLine($"Aluno: {aluno.Nome}, Nota {aluno.Notas}");
            }
        }
    }
}
