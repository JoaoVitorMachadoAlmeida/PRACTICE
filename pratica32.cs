/******************************************************************************
Criar uma Classe Pessoa
Objetivo: Implementar uma classe Pessoa com propriedades para nome e idade, com validação básica.

Tarefas:

Crie uma classe Pessoa com as propriedades Nome e Idade.
A propriedade Nome deve permitir a leitura e a escrita.
A propriedade Idade deve permitir a leitura e a escrita, mas só aceitar valores maiores ou iguais a 0.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Pessoa p = new Pessoa("João Vitor", 18);
    
    p.Nome = "João Vitor";
    p.Idade = -1;
    Console.WriteLine(p.Nome);
    Console.WriteLine(p.Idade);
  }
}
class Pessoa{
    public string Nome{get ; set;}
    private int _idade;
    
    public Pessoa(){
        
    }
    public Pessoa(string nome, int idade){
        Nome = nome;
        _idade = idade;
    }
    public int Idade{
        get{return _idade;}
        set{
            if(value >= 0){
                _idade = value;
            }
        }
    }
}
