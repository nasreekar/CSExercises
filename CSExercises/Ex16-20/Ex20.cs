using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity for TV");
            Double tv = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity for DVD");
            Double dvd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity for MP3");
            Double mp = Convert.ToDouble(Console.ReadLine());

            double tva = tv * 900;
            double dvda = dvd * 500;
            double total = tva + dvda;

            if (total > 5000 && total < 10000)
            {
                total = total - (total * 0.1);
            }
            else if (total > 10000)
            {
                total = total - (total * 0.15);
            }

            double totalprice = total + (mp * 700);
            Console.WriteLine("Total price for this order is ${0}", totalprice);
            Console.ReadLine();
        }
    }
}