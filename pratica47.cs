/******************************************************************************
Sensibilidade a Maiúsculas e Minúsculas
Modifique o programa anterior para que a verificação seja sensível a maiúsculas e minúsculas. Se a palavra estiver presente na frase,
independentemente da capitalização, deve retornar true.

entrada: uma frase e a palavra que ela quer verificar
saida: dizer se a palavra está ou não na frase

bool contem = Veririfcar(frase, palavra)

escrever se a palavra contem ou não

metodo bool Verificar(string frase, string palavra){
    bool contem = false
    
    se frase .Contains palavra{
        return contem = true
    }
    se não{
        return contem;
    }
}
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite a frase: ");
    string frase = Console.ReadLine().ToLower();
    
    Console.WriteLine("Digite a palavra para sua verificação: ");
    string palavra = Console.ReadLine().ToLower();
    
    bool contem = Veririficar(frase, palavra);
    
    if(contem == true){
        Console.WriteLine("A palavra {0} contém na frase",palavra);
    }else{
        Console.WriteLine("A palavra {0} não contém na frase",palavra);
    }
  }
  public static bool Veririficar(string frase, string palavra){
      bool contem = false;
      
      if(frase.Contains(palavra)){
          return contem = true;
      }else{
         return contem;
      }
  }
}
