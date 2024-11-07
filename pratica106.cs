/******************************************************************************

Exercício 3: Calcular a Soma de Todos os Elementos da Matriz
Objetivo: Preencha uma matriz 3x3 com valores inteiros inseridos pelo usuário e calcule a soma de todos os elementos.

Solicite ao usuário valores para preencher a matriz.
Some todos os elementos da matriz.
Exiba a soma total.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[,] matriz = new int[3,3];
    
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write($"Digite o numero da matriz na posição: {i}:{j} - ");
            matriz[i,j] = int.Parse(Console.ReadLine());
        }
    }
     int soma = 0;
        
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                soma+= matriz[i,j];
            }
        }
        
        Console.WriteLine($"A soma dos elementos da matriz é: {soma}");
  }
}
