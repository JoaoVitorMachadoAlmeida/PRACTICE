/*apenas a pratica do curso que estou fazendo de orientação a objeto, nessa parte ele explica topicos especias do c#, switch é algo bem basico, mas não substime o poder da pratica*/
using System;
class HelloWorld {
  static void Main() {
    
    int x = int.Parse(Console.ReadLine());
    string day;
    
    switch(x){
        case 1:
        day = "Sunday";
        break;
        case 2:
        day = "Monday";
        break;
        case 3:
        day = "Tuesday";
        break;
        case 4:
        day = "Wednesday";
        break;
        case 5:
        day = "Thursday";
        break;
        case 6:
        day = "Friday";
        break;
        case 7: 
        day = "Saturday";
        break;
        default:
        day = "Invalid value";
        break;
    }
    Console.WriteLine("Day: " + day);
  }
}
