using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the range till which you want to convert to Hexadecimal");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Hexa Decimal codes:");
            Console.WriteLine("********************\n");
            Console.WriteLine("Integer \t Hexadecimal");
            Hex(num);
        }
        public static string Hex(int i)
        {
            string ret = " ";
            for (int j = 1; j <= i; j++)
            {
                string s1 = j.ToString("X");
                Console.WriteLine("{0} \t\t {1}", j, s1);
            }

            return ret;
        }
    }
}
