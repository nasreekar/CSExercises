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
            double mpa = mp * 700;
            double total = tva + dvda+mpa;

            if (total > 5000 && total < 10000)
            {
                tva = tva - (tva * 0.1);
                dvda = dvda - (dvda * 0.1);
                total = dvda + tva + mpa;
                Console.WriteLine("Total price for this order is ${0}", total);
                Console.ReadLine();
            }
            else if (total > 10000)
            {
                tva = tva - (tva * 0.15);
                dvda = dvda - (dvda * 0.15);
                total = dvda + tva + mpa;
                Console.WriteLine("Total price for this order is ${0}", total);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Total price for this order is ${0}", total);
                Console.ReadLine();
            }
            
        }
    }
}