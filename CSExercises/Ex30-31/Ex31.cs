using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("List of Perfect numbers between 1-1000");
            for(int z=1; z<1000; z++)
            {
                int counter=0;

                for (int x = 1; x < z; x++)
                {
                    if (z % x == 0)
                    {
                        counter = counter + x;
                    }
                }

                if (counter == z)
                {
                    Console.WriteLine(z);
                }
            }
            Console.Read();
        }
    }
}
