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
            for (int y = 0; y < 10; y++)
            {
                Console.Write("Row #" + y);
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(x + " ");
                }
            }
        }
    }
}
