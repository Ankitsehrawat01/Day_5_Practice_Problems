using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Practice_Problems
{
    public class leapyear
    {
        int year;
        public void Leap()
        {
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("It is a Leap Year");
            }
            else
            {
                Console.WriteLine("It is not a Leap Year");
            }
        }
    }
}
