using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int rem;
            bool flag;
            Console.WriteLine("Below are the prime numbers ranging from 5-10000");

            for(int z=5; z<1000;z++)
            {
                flag = true;
                for (int i = 2; i <=z; i++)
                {
                    rem = z % i;
                    if (rem == 0 && i != z)
                    {
                        flag = false;
                        break;
                    }

                }
                if(flag==true)
                    Console.WriteLine(z);
            }
            
           
        }
    }
}
