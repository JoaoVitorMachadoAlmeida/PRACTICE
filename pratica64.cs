/*Solicitar ao usuário para inserir os elementos de uma matriz 3x3.
Calcular a soma dos elementos de cada linha.
Exibir a soma dos elementos de cada linha.*/
using System;
class HelloWorld {
  static void Main() {
    int [,] matriz = new int [3,3];
    
    Console.WriteLine("Insira os numeros da matriz 3x3");
    for(int i = 0; i < 3; i++){
        for(int j = 0; j < 3; j++){
            Console.Write($"Elemento[{i + 1}], [{j + 1}]: ");
            matriz[i,j] = int.Parse(Console.ReadLine());
        }
    }
    
    for(int i = 0; i < 3; i++){
        int somaLinha = 0;
        for(int j = 0; j < 3; j++){
            somaLinha += matriz[i,j];
        }
        Console.WriteLine($"Soma dos elementos da linha {i + 1}: {somaLinha}");
    }
  }
}
