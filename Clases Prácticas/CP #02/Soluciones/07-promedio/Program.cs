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

    int max = Math.Max(a, Math.Max(b, c));
    int min = Math.Min(a, Math.Min(b, c));
    int middle = (a + b + c) - (max + min);

    float average = (a + b + c) / 3f;
    
    Console.WriteLine("El número medio es " + middle + "\nY el promedio de esos números es: " + average);
  }
}