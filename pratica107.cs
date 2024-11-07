/******************************************************************************

Exercício 4: Encontrar o Maior Valor de Cada Linha
Objetivo: Dada uma matriz 3x3, encontre e exiba o maior valor em cada linha.

Preencha a matriz com valores inseridos pelo usuário.
Para cada linha, identifique o maior valor.
Exiba o maior valor de cada linha.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[,] vect = new int[3,3];
    
    for(int i = 0; i < vect.GetLength(0); i++)
    {
        for(int j = 0; j < vect.GetLength(1); j++)
        {
            Console.Write($"Digite o numero do vetor na posição {i}:{j} - ");
            vect[i,j] = int.Parse(Console.ReadLine());
        }
		Console.WriteLine();
    }
    
    int[] maiores = new int[vect.GetLength(0)];
    
    for(int i = 0; i < vect.GetLength(0); i++)
    {
		maiores[i] = vect[i,0];
        for(int j = 1; j < vect.GetLength(1); j++)
        {
           if(maiores[i] < vect[i,j])
		   maiores[i] = vect[i,j];
        }
    }
	 Console.WriteLine("Numeros maiores de cada linha: ");
	  
	  for(int i = 0; i < maiores.Length;i++)
	  	{
		  Console.WriteLine($"{i}° - {maiores[i]}");
 		 }
	}
}
