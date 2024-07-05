/*
Entrada: Nome, email, numero do quarto
Saida: Numero da quarto selecionado com os dados do estudante
** devera sear armazenado em um array usando classes

pedir quantos estudantes vai alugar o quarto
percorrer o array recebendo nome, email e quarto.

percorrer outro array para escrever o arrau intanciando o objeto


classe Estudante{
    Nome
    Email
    
    public class recebe(nome email){
        Nome = nome
        Email = email
    }
    
    override ToString{
        return Nome +"," + Email
    }
}

*/

using System;
class HelloWorld {
  static void Main() {
    Estudantes[]vect = new Estudantes[10];
    Console.Write("Quantos alunos irão alugar o quarto? ");
    int n = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < n; i++){
        Console.WriteLine();
        Console.WriteLine($"Aluguel #{i + 1}");
        Console.Write("Qual é o nome do estudante? ");
        string nome = Console.ReadLine();
        Console.Write("Qual é o email do estudante? ");
        string email = Console.ReadLine();
        Console.Write("Numero do quarto: ");
        int quarto = int.Parse(Console.ReadLine());
        if(quarto >= 0 && quarto < 10){
            vect[quarto] = new Estudantes(nome, email);
        }else{
            Console.WriteLine("Numero do quarto não disponivel");
            i--;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");
        for(int i = 0; i < vect.Length; i++){
            if(vect[i] != null){
                Console.WriteLine(i + ": " + vect[i]);
        }
      }
  }
}
public class Estudantes{
    public string Nome {get;set;}
    public string Email {get;set;}
    
    public Estudantes(string nome, string email){
        Nome = nome;
        Email = email;
    }
    
    public override string ToString(){
        return Nome + "," + Email;
    }
}
