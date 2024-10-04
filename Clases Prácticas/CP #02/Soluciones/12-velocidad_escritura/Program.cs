using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Introduce una oración");
    int startT = Environment.TickCount;
    string? sentence = Console.ReadLine();
    int finishT = Environment.TickCount;
    int result = finishT - startT;
    Console.WriteLine($"Para escribir la oración: {sentence} \nTe demoraste {result / 60} segundos");
  }
}