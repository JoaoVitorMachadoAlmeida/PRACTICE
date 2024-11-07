/******************************************************************************

Exercício 5: Multiplicação por um Escalar
Objetivo: Dada uma matriz 2x2, multiplique todos os elementos por um número fornecido pelo usuário.

Preencha a matriz com valores do usuário.
Solicite ao usuário um número (escalar) para multiplicar todos os elementos da matriz.
Exiba a matriz resultante.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   	int[,] matriz = new int[2,2];
	  
	  for(int i = 0; i < matriz.GetLength(0); i++)
	  {
	  	for(int j = 0; j < matriz.GetLength(1); j++)
		{
			Console.Write($"Digite o numero da posição {i}:{j} - ");
			matriz[i,j] = int.Parse(Console.ReadLine());
		}	
		  Console.WriteLine();
	  }
	  
	  Console.WriteLine("Digite o escalar que deseja: ");
	  int escalar = int.Parse(Console.ReadLine());
	  
	  Console.WriteLine("\nNumeros atualizados: \n");
	  
	  for(int i = 0; i < matriz.GetLength(0); i++)
	  {
	  	for(int j = 0; j < matriz.GetLength(1); j++)
		{
			Console.WriteLine(matriz[i,j] *= escalar);
		}
		  Console.WriteLine();
	  }  
	}
}
