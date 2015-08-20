using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex44
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the strings");
            string x = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the charecters");
            Char ch1 = Convert.ToChar(Console.ReadLine());
            Char ch2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(Substitute(x, ch1, ch2));

        }
        public static string Substitute(string s, char c1, char c2)
        {
            char[] s1 = s.ToCharArray();
            //int counter = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == c1)
                {
                    s1[i] = c2;
                }
            }
            string s2 = new string(s1);
            return s2;
        }
    }
}
