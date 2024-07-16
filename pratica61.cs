/******************************************************************************

Lista de Contatos
Descrição: Crie um programa que gerencie uma lista de contatos. Cada contato deve ter um nome, um número de telefone e um e-mail.

Tarefas:

Adicionar novos contatos à lista.
Remover um contato da lista pelo nome.
Atualizar o número de telefone de um contato.
Ordenar a lista de contatos pelo nome em ordem alfabética.
Exibir todos os contatos.

*******************************************************************************/
using System;
using System.Collections.Generic;
class Program {
  static void Main() {
   List<Contatos> contatos = new List<Contatos>();
   char escolha = '0';

   while(escolha != '6'){
   Console.WriteLine("Lista de Contatos");
   Console.WriteLine("Tecle 1 para adicionar um novo contato");
   Console.WriteLine("Tecle 2 para remover o contato pelo nome");
   Console.WriteLine("Tecle 3 para atualizar número de telefone de um contato");
   Console.WriteLine("Tecle 4 para ordernar a lista de contatos pelo nome");
   Console.WriteLine("Tecle 5 para exibir todos os contatos");
   Console.WriteLine("Tecle 6 para sair");
   escolha = char.Parse(Console.ReadLine());
   Console.Clear();

   switch(escolha){
       case '1':
       AdicionarContato(contatos);
       break;

       case '2':
       RemoverContato(contatos);
       break;

       case '3':
       AtualizarNumero(contatos);
       break;
       case '4':
       OrdenarContato(contatos);
       break;

       case '5': 
       ExibirContatos(contatos);
       break;

       default:
       Console.WriteLine("Opção invalida");
       break;
   }
     


   }

  }
  public static void AdicionarContato(List<Contatos> contatos){
      Console.Write("Nome: ");
      string nome = Console.ReadLine();

      Console.Write("Numero: ");
      string numero = Console.ReadLine();

      if(numero.Length != 9){
          Console.WriteLine("Numero de telefone invalido");
          Console.ReadKey();
          Console.Clear();
           return;
      }

      Console.Write("Email: ");
      string email = Console.ReadLine();
      if(!email.Contains("@")){
          Console.WriteLine("Email invalido");
          Console.ReadKey();
          Console.Clear();
           return;
      }
      Console.Clear();

      contatos.Add(new Contatos(nome,numero,email));
  }

  public static void RemoverContato(List<Contatos> contatos){
      Console.WriteLine("Digite o nome da pessoa que deseja remover dos contatos: ");
      string nome = Console.ReadLine();

       Contatos contatoParaRemover = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (contatoParaRemover != null) {
            contatos.Remove(contatoParaRemover);
            Console.WriteLine("Contato removido com sucesso.");
            Console.ReadKey();
            Console.Clear();
        } else {
            Console.WriteLine("Contato não encontrado.");
            Console.ReadKey();
            Console.Clear();
        }
  }
  public static void AtualizarNumero(List<Contatos> contatos){
      Console.WriteLine("Nome do contato para ser atualizado: ");
      string nome = Console.ReadLine();

         Contatos contatoParaAtualizar = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (contatoParaAtualizar != null) {
            Console.Write("Novo número de telefone: ");
            string novoNumero = Console.ReadLine();

            if (novoNumero.Length != 9) {
                Console.WriteLine("Número invalido");
                return;
            }

            contatoParaAtualizar.Numero = novoNumero;
            Console.WriteLine("Número de telefone atualizado com sucesso.");
        } else {
            Console.WriteLine("Contato não encontrado.");
        }
  }
  public static void OrdenarContato(List<Contatos> contatos){
    contatos.Sort((c1, c2) => c1.Nome.CompareTo(c2.Nome));
    Console.WriteLine("Contatos ordenados por nome.");
  }
  static void ExibirContatos(List<Contatos> contatos) {
      Console.WriteLine("Lista de contatos:");
      foreach (var contato in contatos) {
          Console.WriteLine($"Nome: {contato.Nome}, Número: {contato.Numero}, Email: {contato.Email}");
      }
      Console.WriteLine();
  }
}
class Contatos{
    public string Nome{get;set;}
    public string Numero{get;set;}
    public string Email{get;set;}

    public Contatos(string nome, string numero, string email){
        Nome = nome;
        Numero = numero;
        Email = email;
        }
    }
