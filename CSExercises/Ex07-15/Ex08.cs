using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the centigrade temperature");
            int C = Convert.ToInt32(Console.ReadLine());
            double F = 1.8 * C + 32;
            Console.WriteLine("Fahrenheit temp is {0}", F);
        }
    }
}
