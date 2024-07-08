using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    List<int> numero = new List<int>();
    
    numero.Add(13);
    numero.Add(17); // adicionando elementos numa list
    numero.Add(13);
    numero.Add(11);
    numero.Add(10);
    numero.Insert(2, 4); // colocando o quatro na posição 2
    
    List<string> list = new List<string>(){"Maria", "João", "Pablo", "Julio", "Douglas", "Vinicius", };
    
    foreach(string p in list){
        Console.WriteLine(p);
    }
    foreach(int i in numero){
        Console.WriteLine(i);
    }
    Console.WriteLine("List count: {0}",numero.Count); // numero de elementos na lista
  
    string s1 = list.Find(Teste); // procura na lista o primeiro nome que começa com J, posso tanto chamar pela funcão ou pelo lambda
    
    string s2 = list.FindLast(x => x[0] == 'J'); //expressão lamda
    Console.WriteLine("Primeiro nome que começa com 'J': {0}",s1);
    Console.WriteLine("Ultimo nome que começa com 'J': {0}",s2);
    
    int pos1 = list.FindIndex(x => x[0] == 'J');
    Console.WriteLine("Primeira posição que começa com 'J': {0}",pos1);
    
    int pos2 = list.FindLastIndex(x => x[0] == 'J');
    Console.WriteLine("Ultima posição que começa com 'J': {0}",pos2);
    
    List<string> list2 = list.FindAll(x => x.Length == 5); // cria uma lista que filtra quantos nomes da list contem 5 letras
    Console.WriteLine("------------------------");
    foreach(string obj in list2){
        Console.WriteLine(obj);
    }
    
    list.Remove("Julio"); //  Remove julio da list
    Console.WriteLine("------------------------");
    foreach(string obj in list){
        Console.WriteLine(obj);
    }
    
    list.RemoveAll(x => x[0] == 'J'); // remove todos os nomes que começa com j
    Console.WriteLine("------------------------");
    foreach(string obj in list){
        Console.WriteLine(obj);
    }
    list.RemoveAt(0); //  Remove a posição 0 da lista, que no caso era a maria
    Console.WriteLine("------------------------");
    foreach(string obj in list){
        Console.WriteLine(obj);
    }
     list.RemoveRange(0, 2); // Apartir da posição 0, ele remove 2 elementos
    Console.WriteLine("------------------------");
    foreach(string obj in list){
        Console.WriteLine(obj);
    }
  }
  
  static bool Teste(string a){
      return a[0] == 'J';
  }
}
