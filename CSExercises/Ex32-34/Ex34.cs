using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            string[] name = new string[] { "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10", "S11", "S12" };
            Double[,] marks=new Double[,]{{56,84,68,29},{94,73,31,89},{41,63,36,90},{99,9,18,17},{62,3,65,75},{40,96,53,23},{81,15,27,30},{21,70,100,22},{88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72}};


            Console.WriteLine("Name \t Marks1 \t Marks2 \t Marks3 \t Marks4 \t Total");

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine();
                Double sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    sum = sum + marks[i, j];
                }
                Console.WriteLine("{0} \t {1} \t\t {2} \t\t {3} \t\t {4} \t\t {5}", name[i], marks[i, 0], marks[i, 1], marks[i, 2], marks[i, 3], sum);
            }


            int loop = 1;
            Double total = 0;
            Double avgSub;
            Console.WriteLine("****************************************************************************");
            while (loop <= 4)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        total += marks[i, j];
                    }

                }
                avgSub = total / Convert.ToDouble(name.Length);
                Console.WriteLine("Average of Subject {0} : {1:0.000}", loop, avgSub);
                loop++;
            }

            Double subSum = 0, totalSum = 0;
            double avg;
            Console.WriteLine("****************************************************************************");
            for (int i = 0; i < name.Length; i++)
            {
                subSum = 0;
                for (int j = 0; j < 4; j++)
                {

                    subSum += marks[i, j];
                }
                totalSum += subSum;
            }

            avg =  totalSum / Convert.ToDouble(12 * 4);
            Console.WriteLine("Overall average of marks for the whole class :{0:0.000}", avg);



            Console.Read();
                
        }
    }
}
