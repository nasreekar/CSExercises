using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence or a phrase");
            string x = Console.ReadLine();
            char[] c = x.ToCharArray();
            
            if (c.Length>=1)
            {
                if(c[0]!=char.ToUpper(c[0]))
                    c[0] = char.ToUpper(c[0]);
            }
  
            for(int i=1; i<c.Length;i++)
            {
                if(c[i]==' ')
                {
                    if (c[i+1] != char.ToUpper(c[i+1]))
                        c[i + 1] = char.ToUpper(c[i + 1]);
                }
            }
        Console.WriteLine(c);
            
        }
    }
}
