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
        Console.WriteLine("O que deseja fazer?\n");
        Console.WriteLine("1-Adiconar novo filme para a lista?");
        Console.WriteLine("2-Procurar filme por nome?");
        Console.WriteLine("3-Escolher classificação indicativa?");
        char escolha = char.Parse(Console.ReadLine());

        switch(escolha)
        {
            case '1':
            AdicionarFilmes(filme);
            Console.ReadKey();
            Console.Clear();
            break;
            case '2':
            ProcurarPorNome(filme);
            Console.ReadKey();
            Console.Clear();
            break;
            case '3':
             ProcurarPorClassificacao(filme);
             Console.ReadKey();
            Console.Clear();
            break;
            case '4':
            continuar = false;
            break;
            default:
            Console.WriteLine("Numero inválido, tente novamente");
            Console.ReadKey();
            Console.Clear();
            break;
        }
    }
  }
  public static void AdicionarFilmes(List<Filme> filme)
  {
      Console.WriteLine("Quantos filmes deseja adicionar?");
      int quant = int.Parse(Console.ReadLine());

      for(int i = 0; i < quant; i++){
          Console.Write("Digite o nome do filme: ");
          string nome = Console.ReadLine();
          
          Console.WriteLine("Escolha a classificação etária");
          foreach(var classificacao in Enum.GetValues(typeof(ClassificacaoEtaria)))
          {
              Console.WriteLine($"{(int)classificacao} - {classificacao}");
          }
          
          string classificacaoString = Console.ReadLine();
          
          if(Enum.TryParse(classificacaoString,true, out ClassificacaoEtaria classificacaoEscolhida))
          {
              filme.Add(new Filme(nome,classificacaoEscolhida));
              Console.WriteLine("Filme adicionado com sucesso!\n");
          }
          else
          {
              Console.WriteLine("Classificação inválida. Filme não adicionado.");
          }
      }
  }
  public static void ProcurarPorNome(List<Filme> filme)
  {
      Console.WriteLine("Qual filme deseja procurar?");
      string procura = Console.ReadLine();
      bool encontrado = false;
      
      foreach(var filmes in filme)
      {
          if(procura.Equals(filmes.Nome, StringComparison.OrdinalIgnoreCase))
          {
              Console.WriteLine($"Filme encontrado! Nome: {filmes.Nome}, Classificação: {filmes.Classificacao}");
              encontrado = true;
              break;
          }
      }
      if(!encontrado)
      {
          Console.WriteLine("Filme não encontrado");
      }
  }
  public static void ProcurarPorClassificacao(List <Filme> filme)
  {
      Console.WriteLine("Escolha a classificação indicativa que deseja: ");
      
      foreach(var classificacao in Enum.GetValues(typeof(ClassificacaoEtaria)))
      {
          Console.WriteLine($"{(int) classificacao} - {classificacao}");
      }
      
      string classificacaoString = Console.ReadLine();
      
      if(Enum.TryParse(classificacaoString, true, out ClassificacaoEtaria classificacaoEscolhida))
      {
          Console.WriteLine($"Filmes com a classificação {classificacaoEscolhida} ");
          
          bool encontrado = false;
          
          foreach(var filmes in filme)
          {
              if(filmes.Classificacao == classificacaoEscolhida)
              {
                  Console.WriteLine($"Nome: {filmes.Nome}, Classificação: {filmes.Classificacao}");
                  encontrado = true;
              }
          }
          
          if(!encontrado)
          {
              Console.WriteLine("Nenhum filme encontrado com essa classificação");
          }
      }
      else
      {
          Console.WriteLine("Classificação inválida.");
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
