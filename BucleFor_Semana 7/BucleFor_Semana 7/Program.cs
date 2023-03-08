using System;

class For
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            for (int f = 1; f <= i; f++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
