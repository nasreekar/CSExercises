using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1,-1 };
            Random r = new Random();
            int x=0;
            int[] counter = new int[]{0,0,0,0,0,0,0,0,0,0};

            for(int i=1; i<=50;i++)
            {
                x = r.Next(0, 10);
                for(int j=0;j<arr.Length;j++)
                {     
                        if(arr[j].Equals(-1))
                        {
                            arr[j] = x;
                            break;
                        }
                        else
                        {
                            if (arr[j] == x)
                            {
                                counter[j]++;
                                break;
                            }
                        }     
                 }
            }

            for(int k=0; k<arr.Length;k++)
            {
                Console.WriteLine("The number is {0} and it occured {1} times.", arr[k], counter[k]);
            }

        }
    }
}
