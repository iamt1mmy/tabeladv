using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tabel de adevar al functiei SI");
        Console.WriteLine("");
        Console.WriteLine("---------------------");
        Console.WriteLine("|  X  |  Y  | X & Y |");
        Console.WriteLine("|-----|-----|-------|");

        for (int X = 0; X <= 1; X++)
        {
            for (int Y = 0; Y <= 1; Y++)
            {
                int result = X & Y;
                Console.WriteLine($"|  {X}  |  {Y}  |   {result}   |");
            }
        }

        Console.WriteLine("---------------------");
    }
}