using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please find the below values");

            for(float i=1; i<=10;i++)
            {
                Console.WriteLine("The number is {0:0.0}, Inverse is {1:0.000}, Square root is {2:0.000}, Square is {3:0.0}", i, (1/i), Math.Sqrt(i), (i * i));
            }

            Console.ReadLine();
        }
    }
}
