using System;

class Program {
    static void Main() {
        int[,] matriz = new int[3, 3];
        
        // Solicitar ao usuário para inserir os elementos da matriz
        Console.WriteLine("Insira os elementos da matriz 3x3:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        // Calcular e exibir a soma dos elementos de cada linha
        for (int i = 0; i < 3; i++) {
            int somaLinha = 0;
            for (int j = 0; j < 3; j++) {
                somaLinha += matriz[i, j];
            }
            Console.WriteLine($"Soma dos elementos da linha {i + 1}: {somaLinha}");
        }

        // Calcular e exibir a soma dos elementos de cada coluna
        for (int j = 0; j < 3; j++) {
            int somaColuna = 0;
            for (int i = 0; i < 3; i++) {
                somaColuna += matriz[i, j];
            }
            Console.WriteLine($"Soma dos elementos da coluna {j + 1}: {somaColuna}");
        }
    }
}
