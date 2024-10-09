using System;

class Program
{
  static void Main(string[] args) 
  {
    Console.WriteLine("Introduce el radio: ");
    double r = Convert.ToDouble(Console.ReadLine());
    double AngleArea = (Math.PI *(r * r))/ 6;
    double triangle = (Math.Sqrt(3) * (r * r)) / 4;
    double ang = AngleArea - triangle;
    double area = (triangle * 2) + (ang * 4);
    // area = (((Math.Sqrt(3) * (r * r)) / 4) * 2) + ((((Math.PI *(r * r))/ 6) - ((Math.Sqrt(3) * (r * r)) / 4)) * 4);
    Console.WriteLine($"El área es: {area}cm^2");
  }
}