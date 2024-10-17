using System;

class Divisible
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca un número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca otro número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        if (num2 == 0)
        {
            Console.WriteLine("No es posible dividir entre 0");
        }
        else if (num1 % num2 == 0)
        {
            Console.WriteLine($"{num1} es divisible entre {num2}");
        }
        else
        {
            Console.WriteLine($"{num1} no es divisible entre {num2}");
        }
    }
}
