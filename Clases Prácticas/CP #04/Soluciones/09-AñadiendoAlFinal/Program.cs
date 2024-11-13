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

class ArrayManager
{
  static void Main(string[] args)
  {
    List<(int[], int)> testCases =
    [
      ([1, 2, 28, 13, 14, -2, 0], 2),
      ([3, 1, 2, 4, 14, -2, 0], 3),
      ([], 3)
    ];

    foreach ((int[] array, int val) in testCases)
    {
      Console.WriteLine("Array original:");
      foreach (int item in array)
      {
        Console.Write(item + " ");
      }

      Console.WriteLine("\n");

      int[] modifiedArray = AddToTheEnd(array, val);

      Console.WriteLine($"Array con el {val} agregado:");
      foreach (int item in modifiedArray)
      {
        Console.Write(item + " ");
      }

      Console.WriteLine("\n----------------------------------");
    }

    static int[] AddToTheEnd(int[] array, int val)
    {
      int[] newArray = new int[array.Length + 1];

      for (int i = 0; i < array.Length; i++) newArray[i] = array[i];
      newArray[array.Length] = val;

      return newArray;
    }
  }
}
