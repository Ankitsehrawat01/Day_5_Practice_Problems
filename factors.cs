using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Practice_Problems
{
    public class factors
    {
        int a, b;
        public void Factor()
        {

            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());

            for (b = 2; a > 1; b++)
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is a prime factor {x} times!");
                }

        }
    }
}
