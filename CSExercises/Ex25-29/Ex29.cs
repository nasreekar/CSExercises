using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            for (int x=1; x<num; x++)
            {
                if(num%x==0)
                {
                    Console.WriteLine(x);
                    counter = counter + x;
                }
            }

            if (counter == num)
            {
                Console.WriteLine("The given number {0} is a perfect number", num);
                Console.Read();
            }
            else
                Console.WriteLine("Entered number is not a perfect number");

        }
    }
}
