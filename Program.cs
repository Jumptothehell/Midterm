using System;

namespace Midterm_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            string menu = Console.ReadLine();
            int breakfast = 5;
            int Weekend = 2;
            int cofee = 3;

            while (menu != "End")
            {                
                switch (menu)
                {
                    case "Breakfast Set":
                        if (breakfast != 0)
                        {
                            if (times > 11)
                            { Console.WriteLine("Sorry your order is not available"); }
                            else
                            { breakfast = breakfast - 1; }
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }                     
                        break;
                    case "Weekend Set":
                        if (Weekend != 0)
                        {
                            if (days >= 1 && days <= 5)
                            { Console.WriteLine("Sorry your order is not available"); }
                            else
                            { Weekend = Weekend - 1; }
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;
                    case "Coffee":
                        if (cofee != 0)
                        {
                            cofee = cofee - 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu");
                        break;
                }
                menu = Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
