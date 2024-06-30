using System;

class HelloWorld {
  static void Main() {
    int[,] matriz = new int[5, 5];
    
    PreencherMatriz(matriz);
    Console.WriteLine("Matriz Original:");
    EscreverMatriz(matriz);
    
    TrocarDiagonal(matriz);
    Console.WriteLine("Matriz com Diagonais Trocadas:");
    EscreverMatriz(matriz);
  }

  // Preencher a matriz com valores aleatórios
  public static void PreencherMatriz(int[,] matriz) {
    Random r = new Random();
    for (int i = 0; i < 5; i++) {
      for (int j = 0; j < 5; j++) {
        matriz[i, j] = r.Next(1, 10);
      }
    }
  }

  // Trocar a diagonal principal pela diagonal secundária
  public static void TrocarDiagonal(int[,] matriz) {
    for (int i = 0; i < 5; i++) {
      int temp = matriz[i, i];
      matriz[i, i] = matriz[i, 4 - i];
      matriz[i, 4 - i] = temp;
    }
  }

  // Escrever a matriz no console
  public static void EscreverMatriz(int[,] matriz) {
    for (int i = 0; i < 5; i++) {
      for (int j = 0; j < 5; j++) {
        Console.Write(matriz[i, j] + " ");
      }
      Console.WriteLine();
    }
  }
}
