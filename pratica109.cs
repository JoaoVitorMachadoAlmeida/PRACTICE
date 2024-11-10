/*
Exercício 2: Média de Idades
Crie uma lista de pessoas com as propriedades Nome e Idade. Usando LINQ, faça o seguinte:

Filtre apenas as pessoas com idade maior ou igual a 18.
Calcule a média de idade dessas pessoas.
Exiba a média de idade.
Exemplo:

plaintext
Copiar código
Pessoas:
Nome: Ana, Idade: 17
Nome: Bruno, Idade: 21
Nome: Carla, Idade: 18
Nome: Diego, Idade: 15
Nome: Elisa, Idade: 20
*/
using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var pessoas = new List<Pessoa>
		{
		    new Pessoa("João",18),
		    new Pessoa("Pedro",19),
		    new Pessoa("Rafael",15),
		    new Pessoa("Vitor",28),
		    new Pessoa("Kleber",21),
		    new Pessoa("Junior",13)
		};
		
		var pessoasFiltradas = pessoas
		.Where(x => (x.Idade >= 18))
		.Average(x => x.Idade);
		
		Console.WriteLine($"Media das pessoas maiores de 18: {pessoasFiltradas}");
		
		
		
	}
}
class Pessoa
{
	public string Nome {get;set;}
	public int Idade {get;set;}
	
	public Pessoa(string nome, int idade)
	{
	    Nome = nome;
	    Idade = idade;
	}
}
