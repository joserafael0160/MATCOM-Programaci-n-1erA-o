using System;

class Program
{
  
  static void Main(string[] args)
  {
    int a = 5;
    int b = 9;
    /*
      1 - Con variable auxiliar
          int c = a;
          a = b;
          b = c;
      
      2 - Sin variable auxiliar
          a = a + b
          b = b - a
          a = a - b 
    */

    a = a + b;
    b = a - b;
    a = a - b;
    Console.WriteLine($"El valor de a es {a} y el valor de b es {b}");

  }
}
