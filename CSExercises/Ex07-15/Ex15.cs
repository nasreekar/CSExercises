using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any integer between 100-999");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            int len = num.ToString().Length;

            if (len == 3)
            {
                while (num != 0)
                {
                    int a = num / 100;
                    int b = (num - (a * 100)) / 10;
                    int c = (num - (a * 100) - (b * 10));

                    sum = ((a * a * a) + (b * b * b) + (c * c * c));

                    if (sum == num)
                    {
                        Console.WriteLine("Armstrong number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not an Armstrong number");
                        break;

                    }
                }
            }

            else
                Console.WriteLine("Enter a number which matches the requirements");
        }
    }
}