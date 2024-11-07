/******************************************************************************

Exercício 1: Preencher e Exibir uma Matriz
Crie uma matriz 3x3.
Peça ao usuário para inserir valores em cada posição da matriz.
Imprima a matriz no formato de tabela

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[,] matriz = new int [3,3];
    
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.WriteLine($"Preencha a matriz na posição {i}:{j}");
            matriz[i,j] = int.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine("Matriz completa: ");
    
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i,j] + "\t");
        }
        Console.WriteLine();
    }
  }
}
