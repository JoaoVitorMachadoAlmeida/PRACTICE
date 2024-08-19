/*
Exercício 3: Sistema de Transporte Público
Crie um sistema para gerenciar uma rede de transporte público. Cada Ônibus deve ter um Motorista, uma Rota, e uma lista de Passageiros.

Classes Sugeridas:
Motorista: Contém informações como Nome, NumeroCarteiraMotorista.
Passageiro: Contém informações como Nome, NumeroPassagem.
Rota: Contém informações como NumeroRota e Descricao.
Ônibus: Contém informações como Motorista, Rota, e Passageiros (uma lista de Passageiro).
Funcionalidade:
Implemente métodos para adicionar passageiros ao ônibus e exibir a lista completa de passageiros e informações da rota.
*/
using System;
using System.Collections.Generic;
using System.Globalization;
class HelloWorld {
  static void Main() {
    Bus bus = new Bus();
    List<Passenger> passengers =  new List<Passenger>();
    List<Route> routes = new List <Route>();
    
    bool validation = true;
    while(validation == true)
    {
       Console.WriteLine("Welcome to your bus support, How can i help you?\n");
       Console.WriteLine("1- Add a passenger");
       Console.WriteLine("2- List all passengers");
       Console.WriteLine("3- Add a route");
       Console.WriteLine("4- See route information");
       Console.WriteLine("5- Exit the application.\n");
       Console.Write("Enter your choice: ");
       char choice = char.Parse(Console.ReadLine());
       Console.ReadKey();
       Console.Clear();
       
       switch (choice)
       {
         case '1':
          bus.AddPassenger(passengers);
          break;
          
          case '2':
          bus.PassengersList(passengers);
          break;
          
          case '3':
          bus.AddRoute(routes);
          break;
          
          case '4':
          bus.RouteInfo(routes);
          break;
          
          case '5':
          validation = false;
          break;
       }
    }
    
   
  }
}
/****************************************************************/
class Bus
{
    public Driver Driver {get;set;}
    public List<Route> Routes {get;set;} = new List<Route>();
    public List<Passenger> Passengers {get; set;} =  new List<Passenger>();
    
    public Bus()
    {
    }
    
    public Bus(Driver driver)
    {
        Driver = driver;
    }
    
    public void AddPassenger(List<Passenger> passengers)
    {
        Console.Write("How many passengers do you want to add? ");
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Enter passenger #{i + 1} name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter with ticket number: ");
            int ticketNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
        
            passengers.Add(new Passenger(name,ticketNumber));
        }
        Console.ReadKey();
        Console.Clear();
    }
    
    public void PassengersList(List<Passenger> passengers)
    {
        Console.WriteLine("Passenger list: ");
        foreach(var passenger in passengers)
        {
            Console.WriteLine($"Name: {passenger.Name}, Ticket Number: {passenger.TicketNumber}");
        }
        Console.ReadKey();
        Console.Clear();
    }
    
    public void AddRoute(List <Route> routes)
    {
        Console.Write("How many routes do you wanna add? ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
        Console.Write($"Add the #{i + 1} route number: ");
        int routeNumber = int.Parse(Console.ReadLine());
        
        Console.Write("Add the route description: ");
        string description = Console.ReadLine();
        Console.WriteLine();
        
        
        routes.Add(new Route(routeNumber, description));
        }
        Console.ReadKey();
        Console.Clear();
    }
    
    public void RouteInfo(List <Route> routes)
    {
        Console.WriteLine("Route info:\n");
        
        foreach(var route in routes)
        {
            Console.WriteLine($"Route Number: {route.RouteNumber}\nDescription: {route.Description}\n");
        }
        Console.ReadKey();
        Console.Clear();
    }
}    
/****************************************************************/
class Driver
{
   public string Name {get;set;}
   public int TicketNumber {get;set;}
   
   public Driver()
   {
   }
   
   public Driver(string name, int ticketNumber)
   {
      Name = name;
      TicketNumber = ticketNumber;
   }
}
/****************************************************************/
class Route
{
   public int RouteNumber {get;set;}
   public string Description {get;set;}
   
   public Route()
   {
   }
   
   public Route(int routeNumber, string description)
   {
       RouteNumber = routeNumber;
       Description = description;
   }
}
/****************************************************************/
class Passenger
{
    public string Name {get;set;}
    public int TicketNumber {get;set;}
    
    public Passenger()
    {
    }
    
    public Passenger(string name, int ticketNumber)
    {
        Name = name;
        TicketNumber = ticketNumber;
    }
}
