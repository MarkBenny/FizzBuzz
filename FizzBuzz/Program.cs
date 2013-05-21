using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                for (int m = 0; m <= 100; m++)
                {
                    if (m % 3 == 0 && m % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else if (m % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (m % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(m);
                }
                Console.ReadKey();
            }
        }
    }
}
