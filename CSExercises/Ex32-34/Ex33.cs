using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] num = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            for(int i=0; i<num.Length;i++)
            {
                for(int j=i+1;j<num.Length;j++)
                {
                    if(num[i]<num[j])
                    {
                        int temp = num[j];
                        num[j] = num[i];
                        num[i] = temp;
                    }
                }
               
            }

            for(int k=0;k<num.Length;k++)
            {
                Console.Write("{0} ", num[k]);
            }
        }
    }
}
