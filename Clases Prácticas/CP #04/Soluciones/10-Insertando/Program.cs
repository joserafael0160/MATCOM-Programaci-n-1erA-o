/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un método que, dado un entero pos y un valor 
    val, inserte el valor val en la posición pos de a, 
    desplazando los elementos existentes hacia la derecha, 
    devuelva un nuevo array con el elemento insertado.
**************************************************************
Complejidad: O(n)
**************************************************************/

using System;

class ArrayManager
{
  static void Main(string[] args)
  {
    List<(int[], (int, int))> testCases = [
      ([1, 2, 3, 4], (1, 2)),
      ([1, 2, 4, 5, 7], (1, 3)),
      ([1, 2, 4, 5, 7], (3, 6)),
      ([1, 2, 4, 5, 7], (4, 8))
    ];

    foreach ((int[] array, (int pos, int val)) in testCases)
    {
      Console.WriteLine("Array original:");
      foreach (int element in array)
      {
        Console.Write(element + " ");
      }
      Console.WriteLine("\n");
      Console.WriteLine($"Array modificado (añadiendo {val} en la posición {pos}):");

      int[] modified = Insert(array, pos, val);
      foreach (int element in modified)
      {
        Console.Write(element + " ");
      }
      Console.WriteLine("\n---------------------------------");
    }
  }
  static int[] Insert(int[] array, int pos, int val)
  {
    if (pos >= array.Length) Environment.Exit(1);
    int[] newArray = new int[array.Length + 1];
    for (int i = 0; i < pos - 1; i++)
    {
      newArray[i] = array[i];
    }
    newArray[pos - 1] = val;
    for (int i = pos; i < newArray.Length; i++)
    {
      newArray[i] = array[i - 1];
    }
    return newArray;
  }
}