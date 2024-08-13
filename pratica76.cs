/******************************************************************************
Sistema de Classificação de Filmes
Descrição:
Crie um sistema que classifica filmes com base em diferentes classificações indicativas.

Tarefas:

Defina uma enumeração ClassificacaoIndicativa com as seguintes classificações:

Livre
DezAnos
DozeAnos
QuatorzeAnos
DezesseisAnos
DezoitoAnos

*******************************************************************************/
using System;
using System.Collections.Generic;
class HelloWorld
{
  static void Main() 
  {
    List<Filme> filme = new List<Filme>();
    var continuar = true;
    
    while(continuar == true)
    {
        Console.WriteLine("O que deseja fazer?/n");
        Console.WriteLine("1-Adiconar novo filme para a lista?");
        Console.WriteLine("2-Procurar filme por nome?");
        Console.WriteLine("3-Escolher calssificação indicativa?");
        char escolha = char.Parse(Console.ReadLine());
        
        switch(escolha)
        {
            case '1':
            break;
        }
    }
  }
  public static void AdicionarFilmes(List<Filme> filme)
  {
      Console.WriteLine("Quantos filmes deseja adicionar?");
      int quant = int.Parse(Console.ReadLine());
      
      for(int i = 0; i > quant; i++){
          Console.Write("Digite o nome do filme: ");
          string nome = Console.ReadLine();
          Console.Write("Digite sua classificação etaria:/nLivre/nDezAnos/nDozeAnos/nQuatorzeAnos/nDezesseisAnos/nDezoitoAnos");
          string Classificacao = Console.ReadLine();
      }
  }
}


    public enum ClassificacaoEtaria
    {
        Livre,
        DezAnos,
        DozeAnos,
        QuatorzeAnos,
        DezesseisAnos,
        DezoitoAnos
    }
    
   class Filme
   {
       public string Nome{get;set;}
       public ClassificacaoEtaria Classificacao{get;set;}
       
       public Filme(string nome, ClassificacaoEtaria classificacao)
       {
           Nome = nome;
           Classificacao = classificacao;
       }
   } 



