/******************************************************************************

Exercício 2: Somar Elementos de uma Linha Específica
Objetivo: Dada uma matriz 3x3, peça ao usuário para preencher os valores e calcule a soma dos elementos de uma linha específica.

Preencha a matriz com valores do usuário.
Solicite ao usuário o índice de uma linha (0, 1 ou 2).
Calcule e exiba a soma dos elementos da linha escolhida.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int [,] matriz = new int[3,3];
    
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.WriteLine("Preencha a matriz na posição {0}:{1}",i,j);
            matriz[i,j] = int.Parse(Console.ReadLine());
        }
    }
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        Console.Write($"{i+1}°\t");
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.Write("Qual linha deseja fazer a soma? ");
    int linha = int.Parse(Console.ReadLine());
    int soma = 0;
    
    for(int j = 0; j < matriz.GetLength(1); j++)
    {
        soma += matriz[linha-1,j];
    }
    
    Console.WriteLine($"A soma da linha {linha} é {soma}");
  }
}
