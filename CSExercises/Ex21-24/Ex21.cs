using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
             //Console.WriteLine("Game Starts!!");
             int x = 0;

            while(x!=88)
            {
                Console.WriteLine("Enter a number");
                x = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Lucky You..");
            Console.ReadLine();

        }
    }
}
