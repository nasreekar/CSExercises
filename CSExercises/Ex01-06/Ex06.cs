using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square root of the number is {0}", Math.Sqrt(x));
        }
    }
}
