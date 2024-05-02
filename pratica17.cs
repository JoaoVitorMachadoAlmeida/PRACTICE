using System;
class HelloWorld {
  static void Main() {
    adivinhacao();
  }
  public static void adivinhacao(){
      Console.WriteLine("Bem vindo ao jogo da adivinhação!\nTente adivinhar o numero secreto entre 1 e 100.");
      
      Random random = new Random ();
      
      
      
      int numeroAleatorio = random.Next(0,101);
      
      int tentativa = 0;
      
        for(int i = 1; tentativa != numeroAleatorio; i++ ){
        
        Console.WriteLine($"tentativa {i}: ");
        tentativa = int.Parse(Console.ReadLine());
        if(tentativa < numeroAleatorio)
        {
          Console.WriteLine("O numero misterioso é maior");  
        }
        else if (tentativa > numeroAleatorio)
        {
             Console.WriteLine("O numero misterioso é menor");  
        }
        else 
        {
             Console.WriteLine("Parabéns!!! Você encontrou o numero misterioso");  
        }
    }
  }
}