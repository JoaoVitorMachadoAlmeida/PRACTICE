/******************************************************************************

Escreva um programa que pergunte ao usuário para digitar uma frase e uma palavra. 
O programa deve verificar se a palavra está presente na frase usando o método .Contains.

entrada: frase do usuario / palavra que ele quer verificar
saida: dizer se a palavra que ele quer verificar esta ou não na frase

bool Palavra(string frase,string palavra){
    bool contem = false;
    
    se palavra contem em frase
    contem = true;
}

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite um frase: ");
    string frase = Console.ReadLine();
    
    Console.WriteLine("Qual palavra quer verificar? ");
    string palavra = Console.ReadLine();
    
    bool verificar = Verificar(frase,palavra);
    
    if(verificar == true){
        Console.WriteLine("A palavra {0} contém na frase",palavra);
    }else{
         Console.WriteLine("A palavra {0} não contém na frase",palavra);
    }
  }
  public static bool Verificar(string frase, string palavra){
      bool contem = false;
      
      if(frase.Contains(palavra)){
      return contem = true;
      }else{
          return contem;
      }
  }
}
