using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            int rem;

            if(x==0||x==1)
            {
                Console.WriteLine("Entered number is not a prime number");
            }

            else
            {
                    for(int i=2; i<=x;i++)
                    {
                        rem = x % i;
                        if(rem==0 && i !=x)
                         {
                             Console.WriteLine("The given number {0} is not a prime number",x);
                             return;
                         }
                    }
                    Console.WriteLine("The given number {0} is a prime number", x);
            }
            Console.Read();
        }

    }
}
