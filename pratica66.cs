using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<Aluno> alunos = new List<Aluno>();
        
        Console.Write("Quantas notas serão avaliadas? ");
        int quantNotas = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < quantNotas; i++) {
            Console.Write($"Nome do aluno #{i + 1}: ");
            string nome = Console.ReadLine();
            
            Console.Write("Nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());
            
            alunos.Add(new Aluno(nome, nota));
        }

        CalculadoraDeMedias calculadora = new CalculadoraDeMedias();
        double media = calculadora.CalcularMedia(alunos);
        Console.WriteLine($"\nMédia das notas: {media:F2}");
        
        Console.WriteLine("Notas acima da média:");
        calculadora.ExibirNotasAcimaDaMedia(alunos, media);
    }
}

class Aluno {
    public string Nome { get; set; }
    public double Nota { get; set; }
    
    public Aluno(string nome, double nota) {
        Nome = nome;
        Nota = nota;
    }
}

class CalculadoraDeMedias {
    public double CalcularMedia(List<Aluno> alunos) {
        double soma = 0;
        foreach (var aluno in alunos) {
            soma += aluno.Nota;
        }
        return soma / alunos.Count;
    }

    public void ExibirNotasAcimaDaMedia(List<Aluno> alunos, double media) {
        foreach (var aluno in alunos) {
            if (aluno.Nota > media) {
                Console.WriteLine($"Aluno: {aluno.Nome}, Nota: {aluno.Nota}");
            }
        }
    }
}
