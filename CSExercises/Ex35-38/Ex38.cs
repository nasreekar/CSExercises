using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[]{"John","Venkat", "Mary","Victor","Betty"};
            Double[] marks = new Double[] { 63, 29, 75, 82, 55 };

            //a
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i] < marks[j])
                    {
                        Double temp = marks[j];
                        marks[j] = marks[i];
                        marks[i] = temp;

                        String abc = name[j];
                        name[j] = name[i];
                        name[i] = abc;
                    }
                }
            }
            Console.WriteLine("Students sorted based on marks(descending) \n");
            for (int k = 0; k < marks.Length; k++)
            {
                Console.WriteLine("{0} {1} ", marks[k],name[k]);
            }

            Console.WriteLine("\n ********************************************* \n");
            
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = i + 1; j < name.Length; j++)
                {
                    if (name[i].CompareTo(name[j])==1)
                    {
                        String abc = name[j];
                        name[j] = name[i];
                        name[i] = abc;

                        Double temp = marks[j];
                        marks[j] = marks[i];
                        marks[i] = temp;
                    }
                }
            }
            Console.WriteLine("Students sorted based on Alphabets(ascending) \n");
            for (int l = 0; l < marks.Length; l++)
            {
                Console.WriteLine("{0} {1} ", marks[l], name[l]);
            }

            Console.Read();
        }
    }
}
