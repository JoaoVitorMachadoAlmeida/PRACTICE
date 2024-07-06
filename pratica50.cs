/*
soma de numeros no vetor usando o metodo params
estrada: os numeros para a soma;
saida: a soma dos numeros;
instanciar um objeto em uma variaveal e faze - lo receber a soma

class Calculadora{
    
    public int calc(params int[]vetor){
        int soma = 0;
        pecorrer vetor{
            soma += vetor[i];
        }
        return soma
    }
}

*/
using System;
class HelloWorld {
  static void Main() {
   int s1 = Calculadora.Calc(1, 2, 3);
   int s2 = Calculadora.Calc(1, 2, 3, 5, 6, 43, 8, 6, 4,2);
   
   Console.WriteLine(s1);
   Console.WriteLine(s2);
  }
}
class Calculadora{
    
    
 public static int Calc(params int[]vetor){
     int soma = 0;
     for(int i = 0; i < vetor.Length; i++){
         soma += vetor[i];
     }
     return soma;
 } 
}
