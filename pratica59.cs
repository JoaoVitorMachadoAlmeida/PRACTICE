/******************************************************************************

Crie uma lista de objetos personalizados (por exemplo, Aluno com propriedades Nome e Nota)
Ordene a lista de alunos por nota e exiba os resultados.
*******************************************************************************/
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    List<Alunos> alunos = new List<Alunos>();
    
    Console.Write("Numero de alunos que será analisado: ");
    int n = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < n; i++){
        Console.Write($"Nome do aluno #{i + 1}: ");
        string nome = Console.ReadLine();
        
        Console.Write("Nota do aluno: ");
        double nota = double.Parse(Console.ReadLine());
        
        Console.WriteLine();
        
        alunos.Add(new Alunos(nome,nota));
    }
     alunos.Sort((a1, a2) => a2.Nota.CompareTo(a1.Nota));
        
        Console.WriteLine("Lista de alunos ordenada por nota:");
        foreach (var aluno in alunos) {
            Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");
        }
    
  }
}
class Alunos{
    public string Nome {get;set;}
    public double Nota {get;set;}
    
    public Alunos(string nome, double nota){
        Nome = nome;
        Nota = nota;
    }
}
