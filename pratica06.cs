using System;
class HelloWorld {
    static void Main() {
    int tempo = 0;
    char escolha;

    Console.WriteLine("A viagem será de Belo Horizonte/MG até Porto Seguro/BA");
    Console.WriteLine("Escolha o meio de transporte:[a] Avião | [c] Carro | [o] Ônibus");
    escolha = char.Parse(Console.ReadLine());

    switch(escolha){
        case 'a':
            tempo = 60;
        break;
        case 'c':
            tempo = 455;
        break;

        case 'o':
            tempo = 789;
        break;

        default:
            tempo = 0;
        break;
       }
    if(tempo == 0){
        Console.WriteLine("Veiculo indisponivel");
      }else{
        Console.WriteLine("O veiculo: {0}, leva {1} minutos para chegar ao destino",escolha,tempo);
    }
  }
}
