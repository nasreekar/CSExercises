using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name,gender and age");
            string name = Console.ReadLine();

            //Console.WriteLine("Enter your gender(M/F)");
            string gender = Console.ReadLine();

            //Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (gender)
            {
                case "M":
                    {
                        if (age >= 40)
                        {
                            Console.WriteLine("Good Morning Uncle {0}", name);
                            break;
                        }
                        else
                            Console.WriteLine("Good Morning Mr. {0}", name);
                            break;
                    }

                case "F":
                    {
                        if (age >= 40)
                        {
                            Console.WriteLine("Good Morning Aunty {0}", name);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Good Morning Ms. {0}", name);
                            break;
                        }
                    }

                default:
                    Console.WriteLine("The gender is incorrect");
                    break;

            }
            Console.ReadLine();
        }
    }
}