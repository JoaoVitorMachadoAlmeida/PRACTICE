using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome de uma pessoa: ");
        string nome = Console.ReadLine();

        // Função para contar vogais
        int quantidadeDeVogais = ContarVogais(nome);
        Console.WriteLine($"O nome '{nome}' tem {quantidadeDeVogais} vogais.");

        // Solicitando a inicial e chamando o procedimento para exibir o nome
        Console.Write("Digite a inicial para filtrar o nome: ");
        char inicial = Console.ReadKey().KeyChar;
        Console.WriteLine();
        ExibirSeComecaCom(nome, inicial);
    }

    // Função que conta e retorna o número de vogais no nome
    static int ContarVogais(string nome)
    {
        int contador = 0;
        char[] vogais = new char[] {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        foreach (char c in nome)
        {
            // Verificar cada caractere se é uma vogal
            for (int i = 0; i < vogais.Length; i++)
            {
                if (c == vogais[i])
                {
                    contador++;
                    break; // Parar o loop interno se encontrar uma vogal
                }
            }
        }
        return contador;
    }

    // Procedimento que exibe o nome se começar com a inicial especificada
    static void ExibirSeComecaCom(string nome, char inicial)
    {
        // Comparar a primeira letra do nome com a inicial fornecida
        if (char.ToUpper(nome[0]) == char.ToUpper(inicial))
        {
            Console.WriteLine($"O nome '{nome}' começa com a letra '{inicial}'.");
        }
        else
        {
            Console.WriteLine($"O nome '{nome}' não começa com a letra '{inicial}'.");
        }
    }
}
