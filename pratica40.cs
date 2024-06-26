using System;

class HelloWorld
{
    static void Main()
    {
        // Inicializa um vetor de strings com 5 elementos
        string[] vect = new string[5];

        // Lê 5 palavras do usuário e as armazena no vetor
        for (int i = 0; i < vect.Length; i++)
        {
            Console.Write($"Digite a palavra {i + 1}: ");
            vect[i] = Console.ReadLine();
        }

        // Chama o método Palindromo para verificar e imprimir as palavras palíndromas
        Palindromo(vect);
    }

    static void Palindromo(string[] v)
    {
        // Variável auxiliar para armazenar a palavra atual
        string aux;
        // Variável para determinar se a palavra é um palíndromo
        bool sim;
        // Variáveis para metade do comprimento da palavra e o comprimento total
        int metade, n;

        // Percorre cada palavra no vetor
        for (int i = 0; i < v.Length; i++)
        {
            aux = v[i];
            n = aux.Length;
            metade = n / 2;
            sim = true;

            // Verifica se a palavra é um palíndromo
            for (int x = 0; x < metade; x++)
            {
                if (aux[x] != aux[n - x - 1])
                {
                    sim = false;
                    break;
                }
            }

            // Se for um palíndromo, imprime a palavra
            if (sim)
            {
                Console.WriteLine($"{aux} é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"{aux} não é um palíndromo.");
            }
        }
    }
}
