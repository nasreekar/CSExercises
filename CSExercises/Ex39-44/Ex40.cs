using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the range till which you want to find the square roots ");
            double num = Convert.ToDouble(Console.ReadLine());
            SQT(num);
        }

        public static double SQT(Double y)
        {
            Double sqty;
            for (int i = 1; i <= y; i++)
            {
                sqty = Math.Sqrt(i);
                Console.WriteLine("{0}",sqty);
            }
            return 0;

        }

    }
}
