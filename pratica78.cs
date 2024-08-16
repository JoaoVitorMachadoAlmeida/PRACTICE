/*
Implemente um sistema para gerenciar uma biblioteca. Cada Livro deve ter um autor, título e um conjunto de capítulos.

Classes Sugeridas:
Autor: Contém informações como Nome e DataNascimento.
Capitulo: Contém informações como Numero e Titulo.
Livro: Contém informações como Titulo, Autor, Capitulos (uma lista de Capitulo).
Funcionalidade:
Implemente métodos para adicionar capítulos a um livro e exibir os detalhes do livro, incluindo o título de cada capítulo.
*/
using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
  {
   Writer writer = new Writer("J.K. Rowling", new DateTime(1965, 7, 31)); 
     
   Books books = new Books("Harry Potter", writer);

   books.AddChapter(new Chapter(1, "The Boy Who Lived"));
   books.AddChapter(new Chapter(2, "The Vanishing Glass"));
   books.AddChapter(new Chapter(3, "The Letters from No One"));
     
   books.ShowDetails();   

   
  }
}
/************************************************/
class Books
{
    public string Title { get; set; }
    public Writer Writer { get; set; }
    public List<Chapter> Chapters { get; set; } = new List<Chapter>();

    public Books()
    {
    }

    public Books(string title, Writer writer)
    {
        Title = title;
        Writer = writer;
    }

    public void AddChapter(Chapter chapter)
    {
        Chapters.Add(chapter);
    }

    public void RemoveChapter(Chapter chapter)
    {
        Chapters.Remove(chapter);
    }

    public void ShowDetails()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Writer: " + Writer.Name + " " + Writer.BirthDate);
        Console.WriteLine("Chapters: ");
        foreach (var chapter in Chapters)
        {
            Console.WriteLine("Chapter: " + chapter.Number + " " + chapter.Title);
        }
        
        
    }
}
/**************************************************/
class Writer
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public Writer()
    {
    }

    public Writer(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }

    public void WriterInfo()
    {
        Console.Write("Writer Name: ");
        Name = Console.ReadLine();

        Console.Write("Writer Birth Date: ");
        BirthDate = DateTime.Parse(Console.ReadLine());
    }
}
/**************************************************/

class Chapter
{
    public int Number { get; set; }
    public string Title { get; set; }

    public Chapter()
    {
    }

    public Chapter(int number, string title)
    {
        Number = number;
        Title = title;
    }
}
