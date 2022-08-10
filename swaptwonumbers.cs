using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Parctice_Problems
{
    public class swaptwonumbers
    {
        int number1, number2, temp;
        public void swap()
        {
            Console.Write("Input the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + number1);
            Console.WriteLine("Second Number : " + number2);
        }

    }
}