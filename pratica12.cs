// Escreva um programa em C# que solicite ao usuário o número de notas que deseja inserir e, em seguida, permita que ele insira essas notas. Em seguida, o programa deve calcular e exibir a média dessas notas.
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Numero de notas que deseja inserir: ");
    int numNotas = int.Parse(Console.ReadLine());
    double [] notas = new double [numNotas];
    for (int i = 0; i < numNotas; i++){
        Console.Write("Digite a nota " + (i + 1) + ": ");
        notas[i] = double.Parse(Console.ReadLine());
    }
        
    double somaNotas = 0;
    
    for(int i = 0; i < numNotas; i++){
        somaNotas += notas[i];
    }
    double media = somaNotas / numNotas;
    Console.WriteLine("A media das notas é: {0}", media);

  }
}