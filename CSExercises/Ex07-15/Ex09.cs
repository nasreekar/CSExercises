using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number x");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = (2*(x * x)) - (4 * x) + 3;
            Console.WriteLine("The value of y is {0}", y);
        }
    }
}
