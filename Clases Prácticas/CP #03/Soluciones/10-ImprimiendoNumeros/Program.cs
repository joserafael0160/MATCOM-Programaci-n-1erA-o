class PrintingDescNumbers
{
  static void Main(string[] args)
  {
    Console.Write("Introduce un número: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"\nLos números en orden descendente de {num} hasta 0 son: ");
    PrintDescNum(num);
  }

  static int PrintDescNum(int num)
  {
    if (num < 0)
    {
      Console.WriteLine();
      return num;
    }

    Console.Write(num + " ");
    return PrintDescNum(num - 1);
  }
}