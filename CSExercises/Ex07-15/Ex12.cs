using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance travelled");
            double d = Convert.ToDouble(Console.ReadLine());
            double fcharge = 2.40;
            double fkm = 0.40;
            double totalFare =(fcharge + (d * fkm));
            Console.WriteLine("Total fare of the trip is ${0:#.#0}", Math.Round(totalFare));
        }
    }
}
