using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Introduce un número entero: ");
    int dnum = Convert.ToInt32(Console.ReadLine()) * 2;
    Console.WriteLine("El doble del número es: " + dnum);
  }
}