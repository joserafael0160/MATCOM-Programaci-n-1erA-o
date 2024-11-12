/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Un substring (subcadena) es una secuencia de caracteres 
    que aparece consecutivamente en una cadena mayor. Dados 
    los string s y x, implemente un método que diga si x es 
    substring de s. 
    Ejemplo: 
    1 - ”” es substring de toda cadena 
    2 - ”a” es substring de ”casa” 
    3 - ”asap” no es substring de ”casa”.
**************************************************************
Complejidad: O(n)
**************************************************************/
using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    (string, string)[] testCases = {
      ("casa",""),
      ("casa","house"),
      ("asac","casa"),
      ("asac","aa"),
      ("asac","aaa"),
      ("a","b"),
      ("a","bbab")
    };

    foreach ((string firstWord, string secondWord) in testCases)
    {
      Console.WriteLine(Answer(firstWord, secondWord));
    }
  }
  static string Answer(string a, string b) => IsSubstring(a, b) ? $"✅ Sí, {b} es substring de {a}" : $"❌ No, {b} no es substring de {a}";
  public static bool IsSubstring(string firstWord, string secondWord)
  {
    bool[] seen = new bool[firstWord.Length];
    foreach (char characterOfSecondWord in secondWord)
    {
      bool flag = false;
      for (int i = 0; i < firstWord.Length; i++)
      {
        if (characterOfSecondWord == firstWord[i] && !seen[i])
        {
          flag = true;
          seen[i] = true;
          break;
        } 
      }
      
      if (!flag) return false;
    }
    return true;
  }
}