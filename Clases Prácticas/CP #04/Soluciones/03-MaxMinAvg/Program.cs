/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un programa que lea una secuencia de números de 
    la consola (uno por línea) hasta que se escriba una línea 
    en blanco y de estos imprimir:
    - Mayor
    - Menor
    - Promedio
**************************************************************
Complejidad: O(n)
**************************************************************/

using System;

class MaxMinAvg
{
  static int[] GetInts()
  {
    List<int> numbers = [];
    bool flag = true;

    while (flag)
    {
      Console.Write("Introduce un número: ");
      flag = int.TryParse(Console.ReadLine(),out int num);
      if (flag) numbers.Add(num);
    }
    return [.. numbers];
  }
  static void ShowMaxMinAvg(int[] secuense)
  {
    int max = secuense[0];
    int min = secuense[0];
    int sum = secuense[0];

    for (int i = 1; i < secuense.Length; i++)
    {
      if (max < secuense[i]) max = secuense[i];
      if (min > secuense[i]) min = secuense[i];
      sum += secuense[i];
    }

    double avg = (double)sum / secuense.Length;

    Console.WriteLine($"\nMayor: {max}\nMenor: {min}\nPromedio: {avg}");
  }
  static void Main(string[] args)
  {
    int[] secuense = GetInts();
    if (secuense.Length == 0) 
    {
      Console.WriteLine("La secuencia no contiene números");
      return;
    }
    ShowMaxMinAvg(secuense);
  }
}