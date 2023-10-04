using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el año final: ");
        int final = int.Parse(Console.ReadLine());

        Console.WriteLine("Años bisiestos desde 1900 hasta " + final + ":");

        for (int año = 1900; año <= final; año++)
        {
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                Console.WriteLine(año);
            }
        }
        Console.ReadKey();
    }
}