using System;

class Calculator
{
  static void Main(string[] args) 
  {
    Console.Write("Introduzca un número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Introduzca otro número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Introduzca la operación que desea hacer (+, -, *, /): ");
    string? option = Console.ReadLine();

    Console.Write("\n");

    switch (option)
    {
      case "+":
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
      break;
      
      case "-":
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
      break;
      
      case "*":
        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
      break;

      case "/":
        if (num2 == 0)
        {
          Console.WriteLine("No es posible dividir entre 0");
          Environment.Exit(1);
        }
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
      break;

      default:
        Console.WriteLine("Ha introducido un operador invalido");
      break;
    }
  }
}