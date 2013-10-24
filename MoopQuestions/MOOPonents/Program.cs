using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOOPonents
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("enter a noomber");
            input = Console.ReadLine();

            Console.WriteLine(Math.Pow(Convert.ToInt32(input), 2));
            Console.WriteLine(Math.Pow(Convert.ToInt32(input), 3));
        }
    }
}
