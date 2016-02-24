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
            Console.WriteLine("enter vowel");
            response = Console.ReadLine();
            while (response == "a" || response == "e" || response == "i" || response == "o" || response == "u" ||
                   response == "A" || response == "E" || response == "I" || response == "O" || response == "U")
            {
                Console.WriteLine("OK");
            }
            Console.WriteLine("Error");
        }
    }
}
