/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un método que reciba un array a y devuelva 
    un nuevo array con todos los elementos positivos del 
    array a.
**************************************************************
Complejidad: O(n)
**************************************************************/

using System;
using System.Collections.Generic;

class PositiveFilter
{
  static void Main(string[] args)
  {
    int[] arr = [1, 2, 3, 4, 5, 6, -2, 2];
    int[] newArr = FilterPositiveElements(arr);
    ShowElements(newArr);
  }
  static void ShowElements(int[] array)
  {
    foreach(int i in array)
    {
      Console.Write(i + " ");
    }
  }
  static int[] FilterPositiveElements(int[] array)
  {
    List<int> positiveElements = [];
    foreach (int i in array)
    {
      if (i >= 0) positiveElements.Add(i);
    }
    return [.. positiveElements];
  }
}
