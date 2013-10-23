using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookQuestions
{
    class Furniture
    {
        static void Main(string[] args)
        {
            int Price = 0;
            Console.WriteLine("(P)ine, (O)ak, or (M)ahogony");
            string input = Console.ReadLine();
            if (input == "P" || input == "p")
            {
                Price += 100;
                Console.Write(Price.ToString("C"));
            }
            else if (input == "O" || input == "o")
            {
                Price += 225;
                Console.Write(Price.ToString("C"));
            }
            else if (input == "M" || input == "m")
            {
                Price += 310;
                Console.Write(Price.ToString("C"));
            }
            else
            {
                Price += 0;
                Console.Write(Price.ToString("C"));
            }

        }
    }
}
