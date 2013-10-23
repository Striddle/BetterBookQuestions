using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string CarPrice;
            double value;
            double Commission;

            Console.WriteLine("What price was the car you sold?");
            CarPrice = Console.ReadLine();
            value = Convert.ToDouble(CarPrice);

            if (value <= 15000)
            {
                Console.WriteLine(Commission = value * .05);
            }
            else if (value <= 24000 && value > 15000)
            {
                Console.WriteLine(Commission = value * .07);
            }
            else
            {
                Console.WriteLine(Commission = value * .1 );
            }
            Console.WriteLine("Your commission is: $" + Commission);
        }

    }
}
