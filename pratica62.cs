/******************************************************************************

Lista de Tarefas
Descrição: Crie um programa que gerencie uma lista de tarefas. Cada tarefa deve ter um título, uma descrição e um status (concluída ou não concluída).

Tarefas:

Adicionar novas tarefas à lista.
Marcar uma tarefa como concluída.
Remover uma tarefa da lista pelo título.
Exibir todas as tarefas, mostrando o status de cada uma.

*******************************************************************************/
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    List<Tarefas> tarefas = new List<Tarefas>();
    
    while(true){
    
    Console.WriteLine("Que tarefa deseja realizar?\n ");
    Console.WriteLine("Adicionar tarefa[1] ");
    Console.WriteLine("Marcar uma tarefa como concluida[2] ");
    Console.WriteLine("Remover uma tarefa da lista[3]");
    Console.WriteLine("Exibir todas as tarefas[4] ");
    Console.WriteLine("Sair[5]");
    Console.Write("Escolha uma opção: ");
    char escolha = char.Parse(Console.ReadLine());
    
    Console.Clear();
    switch(escolha){
       case '1':
       AdicionarTarefa(tarefas);
       break;
       
       case '2': 
      MarcarTarefa(tarefas);
      break;
      
      case '3':
      RemoverTarefa(tarefas);
      break;
      
      case '4':
      MostrarTarefa(tarefas);
      break;
      
      case '5':
      return;
      break;
      
      default:
      Console.WriteLine("Opção invalida");
      break;
      }
   }
}
  
  public static void AdicionarTarefa(List<Tarefas> tarefas){
        Console.Write("Quantas tarefas serão adicionadas? ");
    int n = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < n; i++){
        Console.Write($"Titulo da tarefa #{i+1}: ");
        string titulo = Console.ReadLine();
        
        Console.Write("Descrição da tarefa: ");
        string descricao = Console.ReadLine();
        
        Console.WriteLine();
        
       tarefas.Add(new Tarefas(titulo,descricao, false));
         }
         Console.Clear();
    }
    public static void MarcarTarefa(List<Tarefas> tarefas){
        Console.Write("Digite o titulo da tarefa concluida: ");
        string titulo = Console.ReadLine();
        
        Tarefas tarefasParaConcluir = null;
        foreach(var tarefa in tarefas){
            if(tarefa.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)){
                tarefasParaConcluir = tarefa;
                break;
            }
        }
        if(tarefasParaConcluir != null){
            tarefasParaConcluir.Concluida = true;
            Console.WriteLine("Tarefa marcada como concluida");
        }else{
            Console.WriteLine("Tarefa não encontrada");
        }
        Console.ReadKey();
        Console.Clear();
    }
    public static void RemoverTarefa(List<Tarefas> tarefas){
        Console.Write("Digite o titulo da tarefa que será removida: ");
        string titulo = Console.ReadLine();
        
        Tarefas tarefasParaRemover = null;
        
        foreach(var tarefa in tarefas){
            if(tarefa.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)){
                tarefasParaRemover = tarefa;
                break;
            }
        }
        if(tarefasParaRemover != null){
                tarefas.Remove(tarefasParaRemover);
                Console.WriteLine("Tarefa removida com sucesso!");
            }else{
                Console.WriteLine("Tarefa não encontrada");
            }
            Console.ReadKey();
            Console.Clear();
    }
    public static void MostrarTarefa(List<Tarefas> tarefas){
        foreach(var tarefa in tarefas){
           string status = tarefa.Concluida? "Concluida": "Não concluida";
            Console.WriteLine($"Titulo: {tarefa.Titulo}\nDescrição: {tarefa.Descricao}\nConcluida: {status}");
            Console.WriteLine();
        }
        Console.ReadKey();
        Console.Clear();
    }
}
class Tarefas{
    public string Titulo{get;set;}
    public string Descricao{get;set;}
    public bool Concluida{get;set;}
    
    public Tarefas(string titulo, string descricao,bool concluida){
        Titulo = titulo;
        Descricao = descricao;
        Concluida = concluida;
    }
}
