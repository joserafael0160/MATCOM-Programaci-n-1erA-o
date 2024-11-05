/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un método que determine si s es 
    palíndromo (se lee igual al derecho que al
    revés). 
    Ejemplos: ana, anitalavalatina, zz.
**************************************************************
Complejidad: O(n)
**************************************************************/

using System;

class Program
{
  static bool IsPalindrome(string a)
  {
    int middle = a.Length;
    int lastPosition = a.Length - 1;
    for (int i = 0; i < middle; i++, lastPosition--)
    {
      if (a[i] != a[lastPosition]) return false;
    }
    return true;
  }
  
  static string Answer(string a) => IsPalindrome(a) ? $"✅ Sí es un palíndromo - {a}" : $"❌ No es un palíndromo - {a}";

  static void Main(string[] args)
  {
    string[] testCases = ["Hola", "ana", "zz", "anitalavalatina", "er", "a"];

    foreach (string testCase in testCases)
    {
      Console.WriteLine(Answer(testCase));
    }
  }
}