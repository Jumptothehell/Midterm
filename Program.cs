using System;

namespace stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());
            int width;
            int amount = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int Amount0fStair = int.Parse(Console.ReadLine());

            for (int k = 1; k <= Amount0fStair; k++)
            {
                width = amount * k;
                for (int j = 1; j <= high; j++)
                {
                    for (int i = 1; i <= width; i++)
                    {
                        Console.Write(character);
                    }
                    Console.WriteLine("");
                }

            }
        }
    }
}
