using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            long num = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }

        public static long Factorial(long n)
        {
            long fact = 1;
            for (long i = n; i > 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    
     }
}
