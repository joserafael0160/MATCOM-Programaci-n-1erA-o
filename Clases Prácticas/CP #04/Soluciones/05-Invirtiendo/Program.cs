/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un método que dado el array a que recibe 
    como entrada, devuelva otro array con los elementos 
    de a en orden inverso. 
    Ejemplo: 
    recibe: [2, 7, −9] y devuelve [−9, 7, 2].
**************************************************************
Complejidad: O((n / 2) + 1)
**************************************************************/

using System;
using System.Collections.Generic;

class ArrayReverser
{
  static void Main(string[] args)
  {
    Console.WriteLine("Introduce una secuencia de números (déjelo en blanco para terminar): ");
    int[] array = GetInts();
    if (array.Length == 0) {
      Console.WriteLine("Ha introducido una secuencia inválida.");
      Environment.Exit(1);
    }

    int[] reversedArray = ReverseArray(array);
    
    Console.WriteLine("Array original: ");
    ShowArray(array);
    
    Console.WriteLine("Array revertido: ");
    ShowArray(reversedArray);
    
  }
  static void ShowArray(int[] array)
  {
    foreach (int i in array)
    {
      Console.Write(i + " ");
    }
    Console.WriteLine();
  }
  static int[] GetInts()
  {
    List<int> array = [];
    bool flag = true;
    while (flag)
    {
      flag = int.TryParse(Console.ReadLine(), out int n);
      if (flag) array.Add(n);
    }
    
    return [.. array];
  }
  static int[] ReverseArray(int[] array)
  {
    int[] reversedArray = new int[array.Length];
    
    for (int i = 0; i <= array.Length / 2; i++)
    {
      int j = array.Length - i - 1;
      reversedArray[j] = array[i];
      reversedArray[i] = array[j]; 
    }
    return reversedArray;
  }
  
}
