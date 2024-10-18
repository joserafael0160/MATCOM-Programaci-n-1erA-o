using System;

class Max
{
  static void Main(string[] args)
  {
    Console.WriteLine("Introduce un número");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce otro número");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce otro número");
    int num3 = Convert.ToInt32(Console.ReadLine());
    
    int max1 = num1 >= num2 ? num1 : num2;
    int max = max1 >= num3 ? max1 : num3;

    Console.WriteLine($"\nDe {num1}, {num2} y {num3} el mayor es: {max}.");
  }
}