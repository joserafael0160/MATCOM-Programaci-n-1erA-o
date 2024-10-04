using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Introduce un número: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce otro número: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce otro número: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int medio = a + b + c - Math.Min(a, Math.Min(b, c)) - Math.Max(a, Math.Max(b, c));
    float promedio = (a + b + c)/3f;
    Console.WriteLine("El número medio es " + medio + "\nY el promedio de esos números es: " + promedio);
  }
}