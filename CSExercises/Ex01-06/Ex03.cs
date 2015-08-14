using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Square of the number is {0}", x*x);
        }
    }
}
