using System;
using System.Collections.Generic;
using System.Linq;
class HelloWorld {
  static void Main() {
    var songs = new List<Songs>
    {
        new Songs(1, "Bohamian Rhapsody", "Queen", new DateTime (1975,10,31)),
        new Songs(2, "Newborn Me", "Angra", new DateTime (2014,12,17)),
        new Songs(3, "November Rain", "Guns N' ROses", new DateTime (1991,02,18)),
        new Songs(4, "The Show Must Go On", "Queen", new DateTime (1991,10,14)),
    };
    
    Console.WriteLine("Songs released in 1991");
    var songs1991 = songs
    .Where(x => x.ReleaseDate.Year == 1991)
    .ToList();
    
    foreach(var item in songs1991)
    {
        Console.WriteLine(item.ToString());
    }
    
    Console.WriteLine("Songs released on October");
    var songsOnOctober = songs
    .Where(x => x.ReleaseDate.Month == 10)
    .ToList();
    
    foreach(var item in songsOnOctober)
    {
        Console.WriteLine(item.ToString());
    }
    
    Console.WriteLine("Return songs in alphabetical order.");
    var SongsInOrder = songs
    .OrderBy(x => x.Name)
    .ToList();
    
    foreach(var item in SongsInOrder)
    {
        Console.WriteLine(item.ToString());
    }
    
    Console.WriteLine("Last two songs registered in alphabetical order.");
    var SongsLastTwo = songs
    .OrderByDescending(x => x.Name)
    .Take(2)
    .OrderBy(x => x.Name)
    .ToList();
    
    foreach(var item in SongsLastTwo)
    {
        Console.WriteLine(item.ToString());
    }
  }
}
class Songs
{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Band {get;set;}
    public DateTime ReleaseDate {get;set;}
    
    public Songs(int id, string name, string band, DateTime releaseDate)
    {
        Id = id;
        Name = name;
        Band = band;
        ReleaseDate = releaseDate;
    }
    
    public override string ToString() =>
    $"Code: {Id} | Name: {Name} | Band: {Band} | Release Date: {ReleaseDate}";
}
