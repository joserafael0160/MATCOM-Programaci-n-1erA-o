class FactorialProgram
{
  static void Main()
  {
    Console.Write("Introduce un número: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int factorial = Factorial(num);

    Console.WriteLine($"\nEl factorial de {num} es: {factorial}");

  }

  static int Factorial(int num)
  {
    if (num <= 1)
    {
      return 1;
    }
    return Factorial(num - 1) * num;
  }
}