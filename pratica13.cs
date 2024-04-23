// calculo simples mas usado na empresa em que eu trabalho para usar o cartão de crédito 
using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite o valor da compra: ");
        double valorCompra = double.Parse(Console.ReadLine());
        Console.Write("Digite o número de parcelas: ");
        int numeroParcelas = int.Parse(Console.ReadLine());
        double percentualJuros = 3.10;
        double valorJuros = (valorCompra * percentualJuros) / 100;
        double valorJurosTotal= valorJuros * numeroParcelas;
        double valorTotal = valorJurosTotal + valorCompra;
        
        Console.Write("valor por parcela: {0}\nvalor total a passar: {1}",valorJurosTotal, valorTotal);

    }
}
