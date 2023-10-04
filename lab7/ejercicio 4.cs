using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());
        for (int i = 0; i < numero; i++)
        {
            for (int j = 0; j < numero * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.Write("Ingresa un número: ");
        int numero2 = int.Parse(Console.ReadLine());
        for (int i = 0; i < numero2; i++)
        {
            for (int j = 0; j < numero2 * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.Write("Ingresa un número: ");
        int numero3 = int.Parse(Console.ReadLine());
        for (int i = 0; i < numero3; i++)
        {
            for (int j = 0; j < numero3 * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
