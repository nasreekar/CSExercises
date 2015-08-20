using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your marks which is between 0-100");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 80 && marks < 100)
                Console.WriteLine("you have scored {0} marks which is A grade", marks);
            else if (marks >= 60 && marks <= 79)
                Console.WriteLine("you have scored {0} marks which is B grade", marks);
            else if (marks >= 40 && marks <= 59)
                Console.WriteLine("you have scored {0} marks which is C grade", marks);
            else if (marks >= 0 && marks <= 40)
                Console.WriteLine("you have scored {0} marks which is F grade", marks);
            else
                Console.WriteLine("**Error**");

            Console.ReadLine();
        }
    }
}