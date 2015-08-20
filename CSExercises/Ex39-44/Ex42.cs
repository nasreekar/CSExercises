using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the strings");
            string x = Console.ReadLine().ToLower();
            string y = Console.ReadLine().ToLower();

            Console.WriteLine(Convert.ToInt32(FindWord(x, y)));

        }
        public static int FindWord(string s1, string s2)
        {
            int z = 0;
            if (s1.Contains(s2))
            {
                char[] c1 = s1.ToCharArray();
                char[] c2 = s2.ToCharArray();

                for (int i = 0; i < c1.Length; i++)
                {
                    if (c1[i] == c2[0])
                    {
                        z = i + 1; //to get the position from which it is starting added 1 else it would give position in the array i.e i;
                        break;
                    }
                }
                return z;
            }

            else
                return -1;
        }
    }
}
