﻿using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // for (int i = 1; i < 101; i++)
            // {
            //     if (i % 3 == 0 & i % 5 == 0) 
            //     {
            //          continue;
            //     }
            //     if (i % 3 == 0 & i % 5 != 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            //     if (i % 3 != 0 & i % 5 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }                   


            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 & i % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (i % 3 == 0 & i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 3 != 0 & i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }                   
            
                       


                     
           
        }
    }
}
