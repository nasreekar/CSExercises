using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(x);
            Console.WriteLine("Square root of the number is {0}", Math.Sqrt(x));
        }
    }
}
