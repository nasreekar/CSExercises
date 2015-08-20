using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the salary");
            double sal = Convert.ToDouble(Console.ReadLine());
            double ha = 0.1 * sal;
            double ta = 0.03 * sal;
            Console.WriteLine("Total gross salary= {0:c}", sal + ta + ha);
        }
    }
}
