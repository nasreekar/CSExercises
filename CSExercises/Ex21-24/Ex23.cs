using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int counter=0;
            Random r = new Random();
            int num1 = r.Next(0, 10);
            int x=0;

            Console.WriteLine("Number Game starts!!");

            while (x!=num1)
            {
                Console.WriteLine("Enter the number I am thinking");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Try again!!");
                counter++;

            }

            if(counter<=2 && counter>0)
            Console.WriteLine("You are a wizard!!You guessed the lucky number {0}  in {1} times.", x,counter);
            else if(counter>2 && counter<=5)
            Console.WriteLine("You are a good guess!!You guessed the lucky number {0}  in {1} times.",x,counter);
            else
                Console.WriteLine("You are lousy!You guessed the lucky number {0}  in {1} times.", x,counter);
        }
    }
}
