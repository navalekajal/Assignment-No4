﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No4
{
    internal class program6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = i; j <=5; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (i * 1); k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}
