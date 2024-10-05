using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Introduce el número de tu carnet de identidad: ");
    long ID = Convert.ToInt64(Console.ReadLine());
    int aux = Convert.ToInt32(ID / 100000); 
    int day =  aux % 100;
    aux = aux / 100;
    int month = aux % 100;
    aux = aux / 100;
    int year = aux;
    Console.WriteLine($"{day}/{month}/{year}");
    
  }
}