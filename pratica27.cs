using System; // Importa o namespace System, que contém tipos fundamentais e básicos.
using System.Globalization; // Importa o namespace System.Globalization, usado para manipular informações culturais.

namespace Course { // Declara um namespace chamado Course.
    class Program { // Declara a classe Program.
        static void Main(string[] args) { // Ponto de entrada do programa.
            // Solicita e lê os dados do produto do usuário
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine(); // Lê o nome do produto
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê e converte o preço para double
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine()); // Lê e converte a quantidade para int
            
            // Cria uma instância de Produto com os dados fornecidos
            Produto p = new Produto(nome, preco, quantidade);
            
            // Exibe os dados iniciais do produto
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p); // Chama o método ToString() de Produto
            Console.WriteLine();
            
            // Solicita o número de produtos a adicionar ao estoque e atualiza a quantidade
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine()); // Lê e converte a quantidade a ser adicionada
            p.AdicionarProdutos(qte); // Adiciona a quantidade ao estoque
            
            // Exibe os dados atualizados do produto
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p); // Chama o método ToString() de Produto novamente
            Console.WriteLine();
            
            // Solicita o número de produtos a remover do estoque e atualiza a quantidade
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine()); // Lê e converte a quantidade a ser removida
            p.RemoverProdutos(qte); // Remove a quantidade do estoque
            
            // Exibe os dados atualizados do produto
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p); // Chama o método ToString() de Produto novamente
        }
    }

    // Define a classe Produto para representar um produto com nome, preço e quantidade
    class Produto {
        // Declara campos públicos para Nome, Preco e Quantidade
        public string Nome;
        public double Preco;
        public int Quantidade;
        
        // Construtor que inicializa os campos com valores fornecidos
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        
        // Método que calcula o valor total em estoque
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        
        // Método para adicionar produtos ao estoque
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        
        // Método para remover produtos do estoque
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        
        // Sobrescreve o método ToString() para fornecer uma representação de string do produto
        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture) // Formata o preço com duas casas decimais
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); // Inclui o valor total em estoque
        }
    }
}
