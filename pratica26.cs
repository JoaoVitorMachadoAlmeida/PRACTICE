using System;
using System.Globalization;

class ConversordeMoedas{
    public double Dolar;
    public double Reais;
    
    public double Calculo(){
        
        double valor = Dolar * Reais;
        double porcentagem = (valor * 6) / 100;
        return valor + porcentagem;
    }
}
class HelloWorld {
  static void Main() {
    ConversordeMoedas conversor = new ConversordeMoedas();
    
    Console.Write("Qual é a cotação do dolar? ",CultureInfo.InvariantCulture);
    conversor.Dolar = double.Parse(Console.ReadLine());
    Console.Write("Quantos dolares irá comprar? ",CultureInfo.InvariantCulture);
    conversor.Reais = double.Parse(Console.ReadLine());
    Console.Write("Valor a ser pago em reais: {0} ",conversor.Calculo());
    
  }
}
