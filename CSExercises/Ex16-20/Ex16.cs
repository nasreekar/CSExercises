using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name and gender(M/F)");
            string name = Console.ReadLine();
            string gender = Console.ReadLine();

            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr. {0}", name);
            }

            else if (gender == "F")
            {
                Console.WriteLine("Good morning Ms. {0}", name);
            }
            else
                Console.WriteLine("Enter a correct gender");

            Console.ReadLine();
        }

    }
}