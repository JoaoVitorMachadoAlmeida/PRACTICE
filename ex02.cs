using System;                                                 
    class Program {
    public static void Main () {
        int media = 0; //valor nulo para a media
        int n1 , n2 , n3; //declarei 3 variaveis ate então sem numeros
        Console.Write("Digite a primeira nota: "); //auto intuitivo
        string input = Console.ReadLine(); //uso string input pq o console readline vai me voltar uma string invés de um valor, então preciso do input para converter
        int numero = int.Parse(input); //cria uma variavel inteira e usa o int.Parse para enfim converter a string no input
        n1 = numero; // passamos o valor adquirido pelo numero para a variavel n1
        Console.Write("Digite sua segunda nota: ");                        
        string input2 = Console.ReadLine();
        int numero2 = int.Parse(input2);    
        n2 = numero2;
        Console.Write("Digite a terceira nota: ");
        string input3 = Console.ReadLine();
        int numero3 = int.Parse(input3);
        n3 = numero3;
        media = (n1 + n2 + n3)/3; // pegamos a media e atribuimos os valores digitados somados e dividos por 3
        if (n1 < 11 && n2 < 11 && n3 < 11) // aqui crio uma condição que o numero digitado so pode ser ate 10
        {
            Console.Write($"A media de {n1},{n2},{n3} é de: {media}"); //resultado
        }else 
            {
                Console.Write("O numero não pode passar de 10"); //se o numero passar de 10 exibimos essa mensagem
            } 
     }
}
/* versão simplificada
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite a primeira nota");
    double n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota");
    double n2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a terceira nota");
    double n3 = double.Parse(Console.ReadLine());
    
    double media = (n1 + n2 + n3) / 3;
    if(n1 < 11 && n2 < 11 && n3 < 11){
        Console.WriteLine("A media de {0},{1} e {2} é de : {3:0.00}",n1,n2,n3,media);
    }else{
        Console.WriteLine("O valor tem que ser menor que 10");
    }
  }
}
*/