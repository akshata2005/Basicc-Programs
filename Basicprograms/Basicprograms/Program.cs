﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to print power of two");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("power of 2 is" + Math.Pow(2, i));
            }
        }
    }
}
