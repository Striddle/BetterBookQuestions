using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moopagrams
{
    class Monogram
    {
        static void Main()
        {
            DisplayMonogram("S", "T", "R");
            DisplayMonogram("K", "W", "H");
            Console.ReadKey();
        }
        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2} **", first, middle, last);
        }
    }
}
