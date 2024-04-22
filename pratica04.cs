    using System;
    class HelloWorld {
    static void Main() {
    string mes;
    Console.WriteLine("Digite o mês: "); // comando de entrada
    mes = Console.ReadLine().ToLower(); // o usuario digita o mes, o .ToLower() é para colocar tudo em letra minuscula para não dar problema

    switch (mes){ //aqui uso o switch
        case "janeiro": //idico todos os case
        case "março": // em final de cada case colocamos :
        case "maio":
        case "julho":
        case "agosto":
        case "outubro":
        case "dezembro":

        Console.WriteLine("O mês tem 31 dias"); // em todos esses casos vai dar essa mensagem
    break; // break para separar a ação de outros

        case "fevereiro":
        Console.WriteLine("O mês tem 28 ou 29 dias");
     break; //em final de break colocamos ;

        default: // caso nenhum case seja executado
         Console.WriteLine("O mês tem 30 diass");
    break;

    }
  }
}