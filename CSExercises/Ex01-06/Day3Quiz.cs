using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Day3Quiz
    {
        public static void Main(string[] args)
        {
            Double pin = 123456;
            Console.WriteLine("Welcome to the Bank of ISS");
            int counter = 0;

            for (int i=1; i<=3;i++)
            {
                Console.WriteLine("Enter your PIN");
                Double x = Convert.ToDouble(Console.ReadLine());

                if(x!=pin)
                {
                    if(i ==3)
                    {
                        Console.WriteLine("Too Many Wrong PIN entries. Your account is locked");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Pin. Please try again");
                        counter = counter + 1;
                    }   
                }
                else
                {
                    Console.WriteLine("Correct PIN. You can access your account now");
                    return;
                }
            }

            Console.Read();
        }
    }
}
