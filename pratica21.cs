using System;

class Player
{
    public int vida;
    public bool vivo;
    public string nome;
    
    public int InfoV() {
        Console.WriteLine("Digite a vida do {0}:",nome);
        return vida = int.Parse(Console.ReadLine());
        
    }
    public string InfoN() {
        Console.WriteLine("Digite o nome do jogador: ");
        return nome = Console.ReadLine();
    }
    public bool InfoS(){
        if(vida == 0){
            return false;
        }
        else{
            return true;
        }
    }
}

class HelloWorld 
{
    static void Main() 
    {
        
        Player jogador1, jogador2;
        jogador1 = new Player();
        jogador2 = new Player();
        
        jogador1.InfoN();
        jogador2.InfoN();
        Console.WriteLine("A vida do jogador 1: {0}\nA vida do jogador 2: {1}", jogador1.InfoV(), jogador2.InfoV());
        if(jogador1.InfoS() == false){
            Console.WriteLine("{0} está morto",jogador1.nome);
        }else{
            Console.WriteLine("{0} etá vivo",jogador1.nome);
        }
        if(jogador2.InfoS() == false){
            Console.WriteLine("{0} está morto",jogador2.nome);
        }else{
            Console.WriteLine("{0} etá vivo",jogador2.nome);
        }
        
    }
}
