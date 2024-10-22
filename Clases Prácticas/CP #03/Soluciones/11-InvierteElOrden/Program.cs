class PrintingAscNumbers
{
  static void Main(string[] args)
  {
    Console.Write("Introduce un número: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"\nLos números en orden ascendente de 0 hasta {num} son: ");
    PrintAscNum(num);
  }

  static int PrintAscNum(int finalNumber, int num1 = 0)
  {
    if (finalNumber < num1)
    {
      Console.WriteLine();
      return 1;
    }

    Console.Write(num1 + " ");
    return PrintAscNum(finalNumber, num1 + 1);
  }
}