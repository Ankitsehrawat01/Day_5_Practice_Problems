﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Practice_Problems
{
    public class flipcoin
    {
        int chances = 10;
        int head = 0;
        int tail = 0;
        double result;
        Random random = new Random();
        public void flipcoinproblem()
        {
            for (int i = 0; i < chances; i++)
            {
                result = random.NextDouble();
                if (result > 0.5)
                {
                    head++;
                    Console.WriteLine("heads");
                }
                else
                {
                    tail++;
                    Console.WriteLine("tails");
                }
            }
            Console.WriteLine("Chances = " + chances);
            Console.WriteLine("Number of times Heads recieved : " + head);
            Console.WriteLine("Number of times Tails recieved : " + tail);
            double headpercetage = (head * 100 / chances);
            double tailpercetage = (tail * 100 / chances);
            Console.WriteLine("Head Percentage is : " + headpercetage);
            Console.WriteLine("Tail Percentage is : " + tailpercetage);
        }
    }
}

