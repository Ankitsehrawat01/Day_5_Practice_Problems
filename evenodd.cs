using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Practice_Problems
{
    public class evenodd
    {
        int number;
        public void Num()
        {
            Console.WriteLine("Print the number is Even or Odd");
            Console.Write("Enter a Number : ");
            number = (int)Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
