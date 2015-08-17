using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the sides of the triangle");
            Double a = Convert.ToDouble(Console.ReadLine());
            Double b = Convert.ToDouble(Console.ReadLine());
            Double c = Convert.ToDouble(Console.ReadLine());

            Double s = (a + b + c) / 2;
            Double Area = Math.Sqrt((s * (s - a) * (s - b) * (s - c)));
            Console.WriteLine("the area of the triangle is {0:0.000}", Area);

            Console.ReadLine();
        }
    }
}