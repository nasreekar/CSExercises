using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to find the squareroot");
            int N = Convert.ToInt32(Console.ReadLine());

            Random r= new Random();
            int Gr = r.Next(1, (N+1));

            Console.WriteLine("The number guessed randomly is {0}", Gr);
            Double G = Convert.ToDouble(Gr);

            if (Math.Round(Math.Sqrt(N),5) == G)
            {
                Console.WriteLine("The number guessed is {0:0.00000}",G);
            }
            else
            {
                do
                {
                    G = (G + (N / G)) / 2;
                } while ((Math.Round((G * G), 5)) != N);
                Console.WriteLine("The number after iterations is {0:0.00000}", G);
            }
            Console.Read();
        }
        
    }
}
