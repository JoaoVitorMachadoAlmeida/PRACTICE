/*
Exercício 1: Filtrar e Transformar Dados de Clientes
Você tem uma lista de clientes, cada um com Nome, Idade, e Cidade. Realize as seguintes operações:

Filtre apenas os clientes que são maiores de idade (idade > 18).
Projete apenas o Nome e a Cidade desses clientes (use Select).
Ordene a lista resultante alfabeticamente pelo nome.
Exiba o resultado final.
*/

using System;
using System.Collections.Generic;
using System.Linq;
class HelloWorld {
  static void Main() {
    var clients = new List<Clients>
    {
        new Clients ("João", 18, "Ibirité"),
        new Clients ("Igor", 19, "Barreiro"),
        new Clients ("Rafael", 15, "Ibirité"),
        new Clients ("Marcos", 10, "Orlando"),
        new Clients ("Diogo", 25, "Fortaleza"),
        new Clients ("Agnaldo", 42, "Macapá"),
    };
    
    Console.WriteLine("Clients older than 18: ");
    
    var clientsOlder = clients
    .Where(client => (client.Age >= 18))
    .Select(client => new {client.Name, client.City})
    .OrderBy(client => client.Name)
    .ToList();
    
    foreach(var item in clientsOlder)
    {
        Console.WriteLine($"Name: {item.Name} | City: {item.City}");
    }
  }
}
class Clients
{
    public string Name {get;set;}
    public int Age {get;set;}
    public string City {get;set;}
    
    public Clients(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }
}
