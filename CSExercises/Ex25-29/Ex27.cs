using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The graph Starts");
            Console.WriteLine("X \t\t\t Y");
            Console.WriteLine("----------------------------------------");


            for(Double x=-5; x<5; x++)
            {
                Double y = (2 * (x * x)) - (4 * x) + 3;
                Console.WriteLine("{0} \t\t\t {1}", x, y);
            }
            Console.Write("\n");

            for (Double x = -5; x < 5; x++)
            {
                Double y = (2 * (x * x)) - (4 * x) + 3;
                for (int z=1;z<=y;z++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
