
using System;
class HelloWorld {
static void Main() {
char escolha,escolhaA,escolhaProsseguir,escolhaB,cobertura;
double sorvete = 0,coberturaN = 0,valorPG;

    Console.WriteLine("Faça o seu pedido:\n[a]Tradicional [b]Personalizado");
    escolha = Console.ReadLine()[0];

switch(escolha){
    case 'a':
        Console.WriteLine("Escolha entre:\n[a]Chocolate | [b]Baunilha | [c]Morango");
        escolhaA = Console.ReadLine()[0];
    switch(escolhaA){
        case 'a':
        case 'b':
        case 'c':
        Console.WriteLine("O valor é 3,50\nDeseja prosseguir?\n[a]Sim | [b]Não");
        escolhaProsseguir = Console.ReadLine()[0];
        if(escolhaProsseguir == 'a'){
            Console.WriteLine("Pague no caixa o valor de 3,50");
        }else{
            Console.WriteLine("Volte sempre!!!");
        }
        break;

    }
    break;

     case 'b':
            Console.WriteLine("Sorvete: [a]Chocolate | [b]Baunilha | [c]Morango");
            escolhaB = Console.ReadLine()[0];
            switch(escolhaB){
                case 'a':
                case 'b':
                case 'c':
                Console.WriteLine("O valor do sorvete é 3,50");
                sorvete = 3.50;
                
                Console.WriteLine("Escolha a cobertura: [a]Calda de morango | [b]Calda de chocolate | [c]Calda de limão");
                cobertura = Console.ReadLine()[0];
            
                switch (cobertura){
                case 'a':
                Console.WriteLine("O valor da cobertura de morango é 2,50");
                coberturaN = 2.50;
                break;
                
                case 'b':
                Console.WriteLine("O valor da cobertura de chocolate é 3,00");
                coberturaN = 3.00;
                break;
                
                case 'c':
                Console.WriteLine("O valor da cobertura de limão é 3,50");
                coberturaN = 3.50;
                break;
                
                default:
                Console.WriteLine("Escolha inválida");
                break;
                
                }
                valorPG = sorvete + coberturaN;
                Console.WriteLine("O valor total é de: {0:c}",valorPG);
                break;
            }
            
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

        }
    }
}
