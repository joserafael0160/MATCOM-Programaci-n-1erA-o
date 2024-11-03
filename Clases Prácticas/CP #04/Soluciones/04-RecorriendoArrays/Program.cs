/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un método para cada inciso, que reciba un 
    array de enteros y devuelva:
    1. El mayor elemento de un array.
    2. El segundo menor elemento de un array.
    3. Si un número n pertenece al array a.
    4. El promedio de todos los elementos de un array.
    5. La cantidad de elementos que son mayor que el 
    promedio en un array.
**************************************************************
Complejidad: O(n)
**************************************************************/

using System;

class ArrayTraversal
{
  static void Main(string[] args)
  {
    int[] array = [3,5,2,6,1,8];
    int n = 3;

    int maxElement = GetMaxElement(array);
    int secondMinElement = GetSecondMinElement(array);
    string numberIsInArray = IsNumberInArray(n, array) ? "sí" : "no";
    double avg = GetAvg(array);
    int countElementsGreaterThanAvg = CountElementsGreaterThanAvg(array);

    Console.WriteLine($"El máximo elemento es: {maxElement}");
    Console.WriteLine($"El segundo mínimo elemento es: {secondMinElement}");
    Console.WriteLine($"El elemento {n} {numberIsInArray} esta en el array ");
    Console.WriteLine($"El promedio es {avg}");
    Console.WriteLine($"El número de elementos mayor a {avg} que es {countElementsGreaterThanAvg}");
  }
  static int GetMaxElement(int[] array)
  {
    int maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
      if (array[i] > maxElement) maxElement = array[i];
    }
    return maxElement;
  }
  static int GetSecondMinElement(int[] array)
  {
    int minElement = array[0];
    int secondMinElement = int.MaxValue;
    for (int i = 1; i < array.Length; i++)
    {
      if (array[i] <= minElement)
      {
        secondMinElement = minElement;
        minElement = array[i];
      }
      else if (array[i] < secondMinElement) secondMinElement = array[i];
    }
    return secondMinElement;
  }
  static bool IsNumberInArray(int n, int[] array)
  {
    foreach (int i in array)
    {
      if (i == n) return true;
    }
    return false;
  }
  static double GetAvg(int[] array)
  {
    int sum = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
      sum += array[i];
    }
    int avg = sum / array.Length;

    return avg;
  }
  static int CountElementsGreaterThanAvg(int[] array)
  {
    int count = 0;
    double avg = GetAvg(array);
    foreach (int i in array)
    {
      if (avg < i) count++;
    }
    return count;
  }
}
