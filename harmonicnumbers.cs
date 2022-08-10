using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Practice_Problems
{
    internal class harmonicnumbers
    {
        int i, n;
        double sum = 0.0;
        public void Harmonic()
        {
            Console.WriteLine("Print the Nth Harmonic Value");
            Console.WriteLine("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            Console.WriteLine("Sum of Series upto {0} terms : {1}", n, sum);
        }
    }
}
