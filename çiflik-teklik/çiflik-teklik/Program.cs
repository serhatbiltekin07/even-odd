﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çiflik_teklik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if(N % 2 == 0) 
            {
                if(N >=2 && N <=5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (N >=6 && N <=20)
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }
            else
            {
                Console.WriteLine("Weird");
            }
            Console.ReadKey();
        }
    }
}
