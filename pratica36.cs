using System;
class HelloWorld {
  static void Main() {
    double? x = null;
    double? y = 10;
    double w = x ?? 5; //Operador de coalecencia, w recebe o valor de x, mas se x for nulo, w recebe 5
    double z = y ?? 5;
    
    Console.WriteLine(x.GetValueOrDefault());//pega o valor de x ou o valor padrão da variavel, que no caso é 0
    Console.WriteLine(y.GetValueOrDefault());
    
    Console.WriteLine(x.HasValue); // diz se a variavel tem ou não o valor
    Console.WriteLine(y.HasValue);
  
    if(x.HasValue)  //aplicando condicional para vê se x tem um valor  
    Console.WriteLine(x.Value); // pega o valor do objeto null, no caso x não tem valor, entao vai dar erro
    else
    Console.WriteLine("X is Null");
    
    if(y.HasValue)
    Console.WriteLine(y.Value);
    else
    Console.WriteLine("Y is Null");
    
    Console.WriteLine(w);
    Console.WriteLine(z);
  }
}
