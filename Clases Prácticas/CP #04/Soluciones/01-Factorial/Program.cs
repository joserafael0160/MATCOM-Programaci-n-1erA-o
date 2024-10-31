/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un programa que reciba un número entero positivo n de la consola y calcule el
  factorial de ese número.
    El factorial de un número n (denotado como n!) se define como el producto de todos los
  números enteros positivos desde 1 hasta n, o lo que es lo mismo:
    n! = {1          si n = 0     
          n * (n-1)  si n > 0}
**************************************************************
Complejidad: O(n)
**************************************************************/

using System;

class Factorial
{
  static void Main(string[] args)
  {
    Console.Write("Introduzca un número: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int aux = number;
    if (number == 0)
    {
      Console.WriteLine("\n1");
      return;
    }
    int factorial = aux;
    while (aux-- > 1)
    {
      factorial *= aux;

    }
    Console.WriteLine($"\nEl factorial de {number} es: {factorial}");
  }
}