using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x1,y1,x2,y2");
            double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
           // Console.WriteLine("Enter y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double dist = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("Distance {0:#.###}", dist);
        }
    }
}
