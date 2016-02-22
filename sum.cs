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
            string input;
            int response, total;
            total = 0;
            Console.WriteLine("enter number");
            input = Console.ReadLine();
            response = Convert.ToInt32(input);
            while (response < 999)
            {
                total += response;
                Console.WriteLine("enter number");
                input = Console.ReadLine();
                response = Convert.ToInt32(input);
            }
            Console.WriteLine(total);
        }
    }
}
