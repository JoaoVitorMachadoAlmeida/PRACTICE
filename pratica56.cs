using System;

class HelloWorld {
  static void Main() {
    // Declaração de uma matriz bidimensional (2x3) do tipo double
    double[,] mat = new double[2,3];
    
    // Imprime o número total de elementos na matriz
    // mat.Length retorna 6, porque a matriz possui 2 linhas e 3 colunas (2*3)
    Console.WriteLine(mat.Length);
    
    // Imprime o número de dimensões da matriz
    // mat.Rank retorna 2, indicando que é uma matriz bidimensional
    Console.WriteLine(mat.Rank);
    
    // Imprime o número de elementos na primeira dimensão (linhas)
    // mat.GetLength(0) retorna 2, que é o número de linhas da matriz
    Console.WriteLine(mat.GetLength(0));
    
    // Imprime o número de elementos na segunda dimensão (colunas)
    // mat.GetLength(1) retorna 3, que é o número de colunas da matriz
    Console.WriteLine(mat.GetLength(1));
  }
}
