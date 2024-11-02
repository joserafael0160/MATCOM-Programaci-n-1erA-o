/**************************************************************
Nombre: José Rafael Pérez Rivero (C112)

Ejercicio:
    Implemente un programa que reciba un entero n e imprima 
    la suma de los primeros n números impares.
**************************************************************
Complejidad: O(n)
**************************************************************/

using System;

class OddSum
{
  static int CalcOddSum(int n)
  {
    int sum = 0;
    for (int i = 0, odd = 1; i < n; i++, odd += 2) sum += odd;

    return sum;
  }
  static void Main(string[] args)
  {
    Console.Write("Introduzca un número: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int oddSum = CalcOddSum(number);
    
    Console.WriteLine($"\nLa suma de los primeros {number} números impares es: {oddSum}");
  }
}