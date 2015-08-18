using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            string[] month = new string[12]{"Jan","Feb","Mar", "Apr", "may","Jun","Jul","Aug","Sep","Oct","Nov", "Dec"};
            Double[] sales = new Double[12];
            double sum = 0;

            Console.WriteLine("Enter the sales");
            for(int i=0;i<month.Length;i++)
            {
                sales[i] = Convert.ToDouble(Console.ReadLine());
                sum = sum + sales[i];
            }

            Console.WriteLine("S.no \t Month  \t Sales");
            Console.WriteLine("-------------------------------");

            for(int j=0;j<month.Length;j++)
            {
                Console.WriteLine("{0} \t {1}  \t\t {2}",j, month[j], sales[j]);
            }

            Console.WriteLine("Maximum sales recorded is on {0}", sales.Max());
            Console.WriteLine("Minimum sales recorded is on {0}", sales.Min());
            Console.WriteLine("Average sales recorded is on {0}", (sum/month.Length));

            
        }
    }
}
