using System;

class ID
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca tu carnet de identidad: ");
        string? id = Console.ReadLine();
        int? sexId = id?[^2] - '0';
 
        if (sexId % 2 == 0)
        {
            Console.WriteLine("El usuario es un hombre.");
        }
        else
        {
            Console.WriteLine("El usuario es una mujer.");
        }
    }
}
