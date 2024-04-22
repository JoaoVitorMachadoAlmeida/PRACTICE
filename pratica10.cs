    using System;

class Program
{
static void Main()
{
// Declarando e inicializando uma matriz bidimensional
int[,] matriz = {
{ 1, 2, 3 },
{ 4, 5, 6 },
{ 7, 8, 9 }
};
    // Calculando a soma dos elementos da matriz
    int soma = 0;
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            soma += matriz[i, j];
        }
    }

    // Exibindo a matriz e a soma dos elementos
    Console.WriteLine("Matriz:");
    ImprimirMatriz(matriz);
    Console.WriteLine("Soma dos elementos: " + soma);
}

// Método para imprimir a matriz
static void ImprimirMatriz(int[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + "\\t");
        }
        Console.WriteLine();
    }
	}
}