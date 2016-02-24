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
            string input;
            double response;
            Console.WriteLine("Enter your hourly pay rate");
            input = Console.ReadLine();
            response = Convert.ToDouble (input);
            while (response < 5.65 || response > 49.99)
            {
                Console.WriteLine("enter your pay rate");
                input = Console.ReadLine();
                response = Convert.ToDouble (input);
            }
            Console.WriteLine("Error");
        }
    }
}
