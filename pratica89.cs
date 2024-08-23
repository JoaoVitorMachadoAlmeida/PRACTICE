using System;
using System.Globalization;
using System.Collections.Generic;

class Program {
  static void Main() 
  {
    List<Animal> list = new List<Animal>();

    list.Add(new Dog("Dog"));
    list.Add(new Cat("Cat"));
    list.Add(new Bird("Bird"));

    foreach(Animal animal in list)
    {
      Console.Write(animal.Name + " says: ");
      animal.MakeSound();
    }
  }
}
/********************************************************************/
abstract class Animal
{
  public string Name{get;set;}

  public Animal(string name)
  {
    Name = name;
  }
  public abstract void MakeSound();
}
/**********************************************************************/
class Dog : Animal
{
  public Dog(string name) : base(name)
  {
  }

  public override void MakeSound()
  {
    Console.WriteLine("Woof!");
  }
}
/**********************************************************************/
class Cat : Animal
{
  public Cat (string name) : base(name)
  {
  }

  public override void  MakeSound()
  {
    Console.WriteLine("Miau!");
  }
}
/**********************************************************************/
class Bird: Animal
{
  public Bird (string name) : base(name)
  {
  }

  public override void MakeSound()
  {
    Console.WriteLine("Piu!");
  }
}
