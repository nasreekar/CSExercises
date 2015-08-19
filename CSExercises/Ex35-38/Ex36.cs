using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or a phrase or a sentence");
            string word = Console.ReadLine();
            
            if(word!=word.ToLower())
            {
                word = word.ToLower();
            }

            //Console.WriteLine(word);
           StringBuilder sb = new StringBuilder();
           foreach (char c in word) 
           {
               if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
               {
                   word = Convert.ToString(sb.Append(c));
               }
           }

            char[] word1 = word.ToCharArray();
            char[] drow = new char[word1.Length];
            int count = word1.Length;

            for(int i=0; i<count;i++)
            {
                drow[(count-1)-i] = word1[i];

            }

            int counter = 0;

            for (int j = 0; j < count;j++ )
            {
                if (word[j] == drow[j])
                {
                    counter++;
                }
                
            }
            if(counter==count)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }


        }   
    }
}
