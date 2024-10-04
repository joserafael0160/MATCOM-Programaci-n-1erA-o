using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Introduce un número: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce otro número: ");
    int b = Convert.ToInt32(Console.ReadLine());
    float promedio = (a + b)/2f;
    Console.WriteLine("El promedio de esos números es: " + promedio);
  }
}