/*
Crie uma lista de strings que armazena nomes de frutas.
Adicione algumas frutas à lista, remova algumas e depois exiba a lista final.

*/

using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    List<string> frutas = new List<string>();
    Console.Write("Quantas frutas deseja incluir? : ");
    int n = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < n; i++ ){
        Console.Write($"Fruta #{i + 1} : ");
        string fruta = Console.ReadLine();
        frutas.Add(fruta);
        Console.WriteLine();
    }
    Console.Clear();
    Console.WriteLine("Lista de frutas: ");
    foreach(string a in frutas){
        Console.WriteLine(a);
    }
    Console.WriteLine();
    Console.WriteLine("Aperte qualquer tecla para continuar");
    Console.ReadKey();
    Console.WriteLine("Deseja remover algum item da lista?\nS|N");
    char escolha = char.Parse(Console.ReadLine().ToUpper());
    
    switch(escolha){
        case 'S':
        Console.WriteLine("Quer remover o item em qual posição? : ");
        int pos = int.Parse(Console.ReadLine());
        
        if(pos >= 0 && pos < frutas.Count){
        frutas.RemoveAt(pos);
        }
        else{
        Console.WriteLine("posição invalida");
        }
    
        break;
        
        case 'N':
        Console.WriteLine("Nenhum item removido");
        break;
        
         default:
        Console.WriteLine("Comando inválido");
        break;
    }
    Console.WriteLine("Lista atualizada: ");
    foreach(string a in frutas){
        Console.WriteLine(a);
    }
  }
}
