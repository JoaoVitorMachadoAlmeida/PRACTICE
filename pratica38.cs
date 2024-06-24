using System;
using System.Globalization; // Necessário para especificar o formato de cultura ao analisar e formatar valores

// Definição da classe principal onde o programa é executado
class HelloWorld {
    static void Main() {
        // Solicita ao usuário quantos produtos ele deseja incluir na conta
        Console.WriteLine("Quantos produtos para a conta?");
        // Lê a quantidade de produtos e converte para inteiro
        int quantidade = int.Parse(Console.ReadLine());

        // Cria um vetor (array) do tipo Produto com o tamanho especificado pelo usuário
        Produto[] vetor = new Produto[quantidade];

        // Loop para ler o nome e o preço de cada produto
        for(int i = 0; i < quantidade; i++) {
            // Lê o nome do produto
            string name = Console.ReadLine();
            // Lê o preço do produto, utilizando a cultura invariante para suportar o ponto como separador decimal
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Armazena o produto no vetor
            vetor[i] = new Produto { Nome = name, Preco = price };
        }

        // Variável para somar os preços dos produtos
        double soma = 0.0;
        // Loop para somar os preços de todos os produtos no vetor
        for (int i = 0; i < quantidade; i++) {
            soma += vetor[i].Preco;
        }

        // Calcula a média dos preços
        double avg = soma / quantidade;
        // Exibe a média formatada com duas casas decimais
        Console.WriteLine("Preço médio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
    }
}

// Definição da classe Produto
class Produto {
    // Propriedade para armazenar o preço do produto
    public double Preco { get; set; }
    // Propriedade para armazenar o nome do produto
    public string Nome { get; set; }
}
