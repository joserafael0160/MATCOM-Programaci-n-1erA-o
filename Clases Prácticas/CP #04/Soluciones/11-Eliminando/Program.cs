/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un método que, dado un entero pos 
    referente a determinada posición del array a, elimine 
    el elemento que se encuentra en dicha posición, devuelva 
    un nuevo array sin ese elemento.
**************************************************************
Complejidad: O(n)
**************************************************************/

using System;

class ArrayManager
{
  static void Main(string[] args)
  {
    List<(int[], int)> testCases = [
      ([1, 2, 3, 4], 1),
      ([1, 2, 4, 5, 7], 1),
      ([1, 2, 4, 5, 7], 3),
      ([1, 2, 4, 5, 7], 6),
      ([1, 2, 4, 5, 7], 4)
    ];

    foreach ((int[] array, int pos) in testCases)
    {
      Console.WriteLine("Array original:");
      foreach (int element in array)
      {
        Console.Write(element + " ");
      }
      Console.WriteLine("\n");
      Console.WriteLine($"Array modificado (eliminando el elemento en la posición {pos}):");

      int[] modified = Delete(array, pos);
      foreach (int element in modified)
      {
        Console.Write(element + " ");
      }
      Console.WriteLine("\n---------------------------------");
    }
  }
  static int[] Delete(int[] array, int pos)
  {
    if (pos >= array.Length) throw new IndexOutOfRangeException($"El array solo tiene tamaño {array.Length} y la posición {pos} se excede");
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < pos - 1; i++)
    {
      newArray[i] = array[i];
    }
    for (int i = pos; i < array.Length; i++)
    {
      newArray[i - 1] = array[i];
    }
    return newArray;
  }
}