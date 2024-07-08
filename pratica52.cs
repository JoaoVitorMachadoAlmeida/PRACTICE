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
    
    List<string> list = new List<string>(){"Maria", "João", "Pablo"};
    
    foreach(string p in list){
        Console.WriteLine(p);
    }
    foreach(int i in numero){
        Console.WriteLine(i);
    }
    Console.WriteLine("List count: {0}",numero.Count); // numero de elementos na lista
  
    string s1 = list.Find(Teste); // procura na lista o primeiro nome que começa com J, posso tanto chamar pela funcão ou pelo lambda
    
    string s2 = list.FindLast(x => x[0] == 'M'); //expressão lamda
    Console.WriteLine("Primeiro nome que começa com 'J': {0}",s1);
    Console.WriteLine("Primeiro nome que termina com 'a': {0}",s2);
  }
  
  static bool Teste(string a){
      return a[0] == 'J';
  }
}
