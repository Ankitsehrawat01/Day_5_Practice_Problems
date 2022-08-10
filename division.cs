using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Practice_Problems
{
    public class division
    {
        int Divisor, Dividend, Quotient, Reminder;
        public void Div()
        {
            Console.WriteLine("Enter the Divisor");
            Divisor = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Dividend");
            Dividend = (int)Convert.ToInt64(Console.ReadLine());
            Quotient = (int)Convert.ToInt64(Math.DivRem(Dividend, Divisor, out Reminder));
            Console.WriteLine("The Quotient is : " + Quotient);
            Console.WriteLine("The Reminder is : " + Reminder);
        }  

    }
}
