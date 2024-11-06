/*
### Exercício: Listagem de Alunos Aprovados

Você tem uma lista de alunos, onde cada aluno possui as propriedades `Nome`, `Nota` (um valor entre 0 e 10) e `Idade`.

**Objetivo**: Crie uma consulta LINQ para:

1.Filtrar apenas os alunos que foram aprovados (considerando aprovação com `Nota >= 7`).
2.Ordenar os alunos aprovados em ordem alfabética por nome.
3.Projetar apenas o `Nome` e a `Nota` dos alunos aprovados.
4. Exibir o resultado final em uma lista.
*/

using System;
using System.Collections.Generic;
using System.Linq;
class HelloWorld {
  static void Main() {
   var alunos = new List<Alunos>()
   {
       new Alunos ("Ana", 8, 16),
       new Alunos ("Bruno", 5, 17),
       new Alunos ("Carla ", 9, 16),
       new Alunos ("Diego", 6, 16),
       new Alunos ("Elisa", 7, 18),
       new Alunos ("Fernando", 4, 17),
       new Alunos ("Gabriela", 10, 16),
       new Alunos ("Hélio", 3, 18),
       new Alunos ("Isabela", 8, 17),
       new Alunos ("João", 7, 16),
   };
   Console.WriteLine("Alunos Aprovados: ");
   var alunosAprovados = alunos
   .Where(x => (x.Nota >= 7))
   .Select (x => new {x.Nome, x.Nota})
   .OrderBy(x => x.Nome)
   .ToList();
  
  foreach(var item in alunosAprovados)
  {
      Console.WriteLine($"Nome: {item.Nome}, Nota: {item.Nota}");
    }
  }
}
class Alunos
{
    public string Nome {get;set;}
    public int Nota {get;set;}
    public int Idade {get;set;}
    
    public Alunos(string nome, int nota, int idade)
    {
        Nome = nome;
        Nota = nota;
        Idade = idade;
    }
}

