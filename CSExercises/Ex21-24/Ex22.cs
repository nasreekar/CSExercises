using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            while(A!=B)
            {
                if (A > B)
                    A = A - B;
                else
                    B = B - A;
            }

            Console.WriteLine("The HCF of A and B is {0}", A);

        }
    }
}
