using System;

class AddingHours
{
  static void Main()
  {
    Console.Write("Diga la hora a sumar: ");
    int? addHour = Convert.ToInt32(Console.ReadLine());
    Console.Write("Diga los minutos a sumar: ");
    int? addMin = Convert.ToInt32(Console.ReadLine());

    Console.Write("Diga la hora inicial: ");
    string?[]? initialTime = Console.ReadLine()?.Split(":");

    int? addTimeMin = (addHour * 60) + Convert.ToInt32(addMin);
    int initialTimeMin = (Convert.ToInt32(initialTime?[0]) * 60) + Convert.ToInt32(initialTime?[1]);
  
    int? totalMinutes = addTimeMin + initialTimeMin;
    int? finalHours = totalMinutes / 60;
    int? finalMin = totalMinutes % 60;
    Console.WriteLine($"\nEl tiempo es de: {finalHours}:{finalMin}");
  }
}