﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number which you want to be squared");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Square of the number is = {0}", x*x );
        }
    }
}
