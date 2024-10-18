using System;

class Plane
{
  static void Main()
  {
    Console.Write("Diga la hora de salida del avión: ");
    string?[]? departure = Console.ReadLine()?.Split(":");
    Console.Write("Diga la hora de llegada del avión: ");
    string?[]? arrival = Console.ReadLine()?.Split(":");
   
    int departureMin = Convert.ToInt32(departure?[0]) * 60 + Convert.ToInt32(departure?[1]);
    int arrivalMin = Convert.ToInt32(arrival?[0]) * 60 + Convert.ToInt32(arrival?[1]);

    int dif =  arrivalMin - departureMin;
    int hour = dif / 60;
    int minutes = dif % 60;
    
    Console.WriteLine($"\nEl tiempo de vuelo fue de {hour}:{minutes}");
  }
}