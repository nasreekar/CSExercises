using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int HCF = 0;
            int A1 = A;
            int B1 = B;

            while(A1!=B1)
            {
                if (A1 > B1)
                {
                    A1 = A1 - B1;
                    HCF=A1;
                }
                else
                {
                    B1 = B1 - A1;
                    HCF=B1;
                }
            }

            int LCM = (A * B) / HCF;

            Console.WriteLine("HCF:{0}", HCF);
            Console.WriteLine("LCM<:{0}", LCM);
            Console.Read();

        }
    }
}
