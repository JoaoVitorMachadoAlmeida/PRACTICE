using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
           
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           /* Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());*/
            
            Produto p = new Produto(nome, preco/*quantidade(apaguei a quantidade para e vai ser iniciada com o 0, mas se quiser posso colocar já a quantidade)*/);
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            
        }
    }

   class Produto {
    public string Nome;
    public double Preco;
    public int Quantidade;
    
    public Produto(string nome, double preco, int quantidade){
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
    
    public Produto(string nome, double preco){
        Nome = nome;
        Preco = preco;
        Quantidade = 0; //se eu quiser posso apagar essa linha mas é so pra mostrar que já posso atribuir o valor no atributo
    }
    
    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
    }
    public void AdicionarProdutos(int quantidade) {
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade) {
        Quantidade -= quantidade;
    }
    public override string ToString() {
        return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
