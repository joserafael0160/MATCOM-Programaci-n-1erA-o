using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Introduce una cadena de caracteres: ");
    string? texto = Console.ReadLine();
    Console.WriteLine("Introduce un número entero menor que: " + texto?.Length);
    int numInd = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("El carácter que está en la posicion " + numInd + " es " + texto?[numInd - 1]);
  }
}