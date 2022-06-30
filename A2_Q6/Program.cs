using System;

namespace A2_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            double positiveCount = 0, negativeCount = 0, sum = 0;
            Console.WriteLine("Write Number of Integers to be entered !");
            int Number = Convert.ToInt32(Console.ReadLine());

            int[] terms = new int[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Write integers to be entered !");
                int value = Convert.ToInt32(Console.ReadLine());
                terms[i] = value;
            }

            Console.WriteLine("Integers you wrote are\n ");

            for (int m = 0; m < Number; m++)
            {
                Console.Write(" " + terms[m] + "\n");
                sum = sum + terms[m];
                if(terms[m]>0)
                {
                    positiveCount++;
                }
                else
                {
                    negativeCount++;
                }
            }
            double average;
            average= sum / Number;
            Console.WriteLine("\nPositive Integers are "+positiveCount+"\n Negative Integers are "+negativeCount);
            Console.WriteLine("\nTotal is " + sum + "\n Average is " + average);
        }
    }
}
