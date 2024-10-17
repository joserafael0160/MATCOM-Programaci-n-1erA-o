using System;

class AbsoluteValue
{
  static void Main(string[] args)
  {
    Console.Write("Introduce un valor: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int absValue = x < 0 ? x * -1 : x;
    Console.WriteLine($"\nEl valor absoluto de {x} es: {absValue}");
  }
}