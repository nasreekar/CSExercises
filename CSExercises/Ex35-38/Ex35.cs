using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase");
            string x = Console.ReadLine();
            char[] c = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int counter = 0;
            

            for (int i = 0; i < x.Length; i++)
            {
                for(int j=0;j<c.Length;j++)
                {
                    if(c[j]== Convert.ToChar(x.Substring(i,1)))
                    {
                        counter++;
                        break;
                    }
                }
            }

            Console.WriteLine("Total number of vowels: {0}", counter);


            //b

            Console.WriteLine("**************************************************");
            int d1=0, d2=0, d3=0, d4=0, d5 = 0;
            
            for (int i = 0; i < x.Length; i++)
            {
               if (c[0] == Convert.ToChar(x.Substring(i, 1)))
                 {
                     d1 = d1 + 1;
                 }
               else if (c[1] == Convert.ToChar(x.Substring(i, 1)))
               {
                   d2 = d2 + 1;
               }
               else if (c[2] == Convert.ToChar(x.Substring(i, 1)))
               {
                   d3 = d3 + 1;
               }
               else if (c[3] == Convert.ToChar(x.Substring(i, 1)))
               {
                   d4 = d4 + 1;
               }
               else if (c[4] == Convert.ToChar(x.Substring(i, 1)))
               {
                   d5 = d5 + 1;
               }
        }

            Console.WriteLine("Number of a: {0}", d1);
            Console.WriteLine("Number of a: {0}", d2);
            Console.WriteLine("Number of a: {0}", d3);
            Console.WriteLine("Number of a: {0}", d4);
            Console.WriteLine("Number of a: {0}", d5);

            Console.Read();
        }
    }
}
