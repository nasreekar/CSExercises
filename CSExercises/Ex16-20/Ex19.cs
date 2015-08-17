using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the total distance travelled");
            Double km = Convert.ToDouble(Console.ReadLine());
            km = km * 1000;
            km = Math.Ceiling(km / 100);

            double minc = 2.4;
            double totalfare = 2.4  + (85 * 0.04) + ((km - 90) * 0.05);

            Console.WriteLine("Total fare of the trip is ${0:0.00}", totalfare);
            Console.ReadLine();

        }
    }
}