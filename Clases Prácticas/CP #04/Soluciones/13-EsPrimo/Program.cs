/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Determinar si un número entero positivo es primo. Un 
    número es primo si solo tiene dos divisores: 1 y el 
    propio número.
**************************************************************
Complejidad: O(√n)
**************************************************************/

using System;

class Program
{
  static bool IsPrime(int n)
  {
    if (n < 2) return false;

    int sqrt = (int)Math.Sqrt(n);
    for (int i = 2; i <= sqrt; i++)
    {
      if (n % i == 0) return false;
    }
    return true;
  }

  static void Main(string[] args)
  {
    static string answer(int n) => IsPrime(n) ? $"{n} ✅ Sí es primo" : $"{n} ❌ No es primo";

    int[] testCases = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];

    foreach (int testCase in testCases)
    {
      Console.WriteLine(answer(testCase));
    }
  }
}
