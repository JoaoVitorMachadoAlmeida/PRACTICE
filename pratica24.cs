using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Lê a entrada do console
        Console.WriteLine("Digite os números separados por espaço:");
        string input = Console.ReadLine();
        
        // Divide a entrada em partes e converte cada uma em um inteiro
        int[] numArray = input.Split(' ').Select(int.Parse).ToArray();
        
        // Chama o método para encontrar e exibir o menor número
        MostrarMenorNumero(numArray);
    }

    static void MostrarMenorNumero(int[] array)
    {
        // Verifica se o array está vazio
        if (array.Length == 0)
        {
            Console.WriteLine("O array está vazio.");
            return;
        }
        
        // Inicializa o menor número como o primeiro elemento do array
        int menorNumero = array[0];
        
        // Itera pelo array para encontrar o menor número
        foreach (int num in array)
        {
            if (num < menorNumero)
            {
                menorNumero = num;
            }
        }
        
        // Exibe o menor número
        Console.WriteLine("O menor número do array é: " + menorNumero);
    }
}
