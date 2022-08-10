using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Practice_Problems
{
    public class poweroftwo
    {
        int N = 0;
        public void Power()
        {
            while (N < 31)
            {
                N++;
                long power = (long)Convert.ToInt64(Math.Pow(2, N));
                Console.WriteLine("The result of is : " + power);
            }
        }
    }
}
