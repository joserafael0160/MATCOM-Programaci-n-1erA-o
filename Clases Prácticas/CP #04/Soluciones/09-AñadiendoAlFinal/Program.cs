/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un método que reciba un valor val y añada 
    dicho valor al final del array a, devolviendo un nuevo 
    array con el elemento añadido. 
**************************************************************
Complejidad: O(n)
**************************************************************/
using System;

class PerfectNumberChecker
{
  static void Main(string[] args)
  {
    int[] testCases = [1, 2, 28, 13, 14, -2, 0];
    
    foreach (int i in testCases)
    {
      string answer = Answer(i);
      Console.WriteLine(answer);
    }
  }

  static string Answer(int n) => IsPerfect(n) ? $"✅ Sí, el número {n} es perfecto" : $"❌ No, el número {n} no es perfecto";

  public static bool IsPerfect(int n)
  {
    if (n < 1) return false;
    int divisorsSum = 1;
    int limit = n / 2;

    for (int i = 2; i <= limit; i++)
    {
      if (n % i == 0) divisorsSum += i;
    }

    return divisorsSum == n;
  }

}
