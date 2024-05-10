using System;
using System.Globalization;

class Produto{
    public string Nome;
    public double Preco;
    public int Quantidade;
    
    public double ValorTotalEmEstoque(){
        return Preco * Quantidade;
    }
    
    public void AdicionarProdutos(int quantidade){
        Quantidade = Quantidade + quantidade; //operação para adicionar a quantidade, poderia usaar tbm só Quantidade += quantidade
    }
    public void RemoverProdutos(int quantidade){
        Quantidade = Quantidade - quantidade; //operação para diminuir a quantidade
    }
    
    public override string ToString(){ //passando um objeto para string
        return Nome 
        +", $" 
        +Preco.ToString("F2",CultureInfo.InvariantCulture)
        +", "            // ele vai escrever isso tudo quando eu colocar só "p"
        + Quantidade    //estou basicamente me poupando tempo e não precisar escrever isso tudo de novo quando eu precisar desses dados
        + " unidades, Total: $"
        + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
    }
}
class HelloWorld {
  static void Main() {
   Produto p = new Produto();
   
   Console.WriteLine("Entre com os dados do produto: ");
   Console.Write("Nome: ");
   p.Nome = Console.ReadLine();
   Console.Write("Preço: ");
   p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   Console.Write("Quantidade: ");
   p.Quantidade = int.Parse(Console.ReadLine());
   
   Console.WriteLine("Dados do produto: "+p); //o c# entende que o p esta numa concatenação de string, por isso não preciseu colocar o ToString aqui
 
    Console.Write("Digite o número de produtos a serem adicionados: ");
    int qte = int.Parse(Console.ReadLine());
    p.AdicionarProdutos(qte); //adicionei a quantidade que o usuario digite em cima
    
    Console.WriteLine(); // to simplesmente quebrando a linha para ficar bonito
    Console.WriteLine("Dados atualizados: "+p);
    
    Console.Write("Digite o numero de produtos a serem removidos: ");
    qte = int.Parse(Console.ReadLine());
    p.RemoverProdutos(qte);
    
    Console.WriteLine();
    Console.WriteLine("Dados atualizados: "+p);
      
  }
}
