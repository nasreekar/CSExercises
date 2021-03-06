using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find factorial");
            int x = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

          /* To find factorial using increment
             
            for(int i=1; i<=x;i++)
            {
                fact=i * fact;
            }
            Console.WriteLine("the factorial of the number is {0} is {1}", x, fact);
            Console.ReadLine();
          */

          // to find factorial using decrement
           for (int i=x; i>1; i--)
           {
               fact = fact * i;
           }
           Console.WriteLine("the factorial of the number is {0} is {1}", x, fact);
           Console.ReadLine();
        }
    }
}
