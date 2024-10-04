// Fórmula de Bhaskara
// (-b +- sqrt((b * b) - (4 * a * c)))/(2 * a)

using System;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Introduce a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce c: ");
    int c = Convert.ToInt32(Console.ReadLine());
    
    int divisor = 2 * a;
    int calc = (b * b) - (4 * a * c);
    double x1 = (-b + Math.Sqrt(calc)) / divisor;
    double x2 = (-b - Math.Sqrt(calc)) / divisor;
    Console.WriteLine($"Soluciones: {x1}, {x2}");
  }
}