using System;

class Program
{
  static int Max(int a, int b)
  {
      return (a + b + Math.Abs(a - b)) / 2;
  }

  static int Min(int a, int b)
  {
    return (a + b - Math.Abs(a - b)) / 2;
  }

  static void Main(string[] args)
  {
    Console.WriteLine("Introduce un número: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce otro número: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int maxValue = Max(a,b);
    int minValue = Min(a,b);
    Console.WriteLine("El mayor es: " + maxValue + "\nY el menor es: " + minValue);

  }
}