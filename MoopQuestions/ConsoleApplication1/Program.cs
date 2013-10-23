using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            string Area;
            string Minutes;
            int[] AreaCodes = new int[6]{262, 414, 608, 715, 815, 920};
            double[] rates = new double[6]{.07, .10, .05, .16, .24, .14};
                
            Console.WriteLine ("WAT IS YO AREA CODE?");
            Area = Console.ReadLine();
            Console.WriteLine("WAT WAS YO LENGTH OF CALL?");
            Minutes = Console.ReadLine();

            for (int i = 0; i< AreaCodes.Length; i++)
            {
                if (Area == AreaCodes[i].ToString())
                {
                    price = rates[i] * Convert.ToInt32(Minutes);
                    Console.WriteLine(price.ToString ("C"));
                }
            }
        }
    }
}
