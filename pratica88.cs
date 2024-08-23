using System;
using System.Collections.Generic;

class Program {
  static void Main() 
  {
    List <Vehicle> list = new List<Vehicle>();

    list.Add(new Car("BMW", "X5", 4));
    list.Add(new Motorcycle("Kawasaki", "Ninja",true));
    list.Add(new Truck("Volvo", "FH", 2));

    foreach(Vehicle vehicle in list)
    {
      vehicle.VehicleInfo();
      vehicle.StartEngine();
      Console.WriteLine();
    }
  }
}
/********************************************************************/
abstract class Vehicle
{
  public string Brand { get; }
  public string Model { get; }

  public Vehicle(string brand, string model)
  {
    Brand = brand;
    Model = model;
  }
  public abstract void StartEngine();

  public virtual void VehicleInfo()
  {
    Console.WriteLine(Brand + " " + Model);
  }
}
/********************************************************************/
class Car : Vehicle
{
  public int NumberOfDoors { get; }

  public Car(string brand, string model, int numberOfDoors) : base(brand, model)
  {
    NumberOfDoors = numberOfDoors;
  }

  public override void StartEngine()
  {
    Console.WriteLine("Starting the car's engine...");
  }
  public override void VehicleInfo()
  {
    base.VehicleInfo();
    Console.WriteLine("Number of doors: " + NumberOfDoors);
  }
}
/********************************************************************/
class Motorcycle : Vehicle
{
  public bool HasSidecar { get; }

  public Motorcycle(string brand, string model, bool hasSidecar) : base(brand, model)
  {
    HasSidecar = hasSidecar;
  }
  public override void StartEngine()
  {
    Console.WriteLine("Starting the motorcycle's engine...");
  }
  public override void VehicleInfo()
  {
    base.VehicleInfo();
    Console.WriteLine("Has sidecar: " + HasSidecar);
  }
}
/********************************************************************/
class Truck : Vehicle
{
  public double LoadCapacity { get; }

  public Truck(string brand, string model, double loadCapacity) : base(brand, model)
  {
    LoadCapacity = loadCapacity;
  }
  public override void StartEngine()
  {
    Console.WriteLine("Starting the truck's engine...");
  }
  public override void VehicleInfo()
  {
    base.VehicleInfo();
    Console.WriteLine("Load capacity: " + LoadCapacity + " tons");
  }
}
