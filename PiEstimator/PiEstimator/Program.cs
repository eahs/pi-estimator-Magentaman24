using System;

namespace PiEstimator
{
    class Program
    {
        static void Main(string[] args) 
        {
            long n;
            
            Console.WriteLine("Pi Estimator");
            Console.WriteLine("================================================");

            n = GetNumber("Enter number of iterations (n): ");

            double pi = EstimatePi(n);
            double diff = Math.Abs(pi - Math.PI);

            Console.WriteLine();
            Console.WriteLine($"Pi (estimate): {pi}, Pi (system): {Math.PI}, Difference: {diff}");
        }

        static double EstimatePi(long n)
        {
            Random rand = new Random(System.Environment.TickCount);
            double pi = 0.0;
            double temp = 0.0; 

            // TODO: Calculate Pi

            for (int i = 0; i <= n; i++)
            {
                pi = 4 * Math.Atan(.2) - Math.Atan(1 / 239);
                
                pi = pi * 4; 
                //pi = 22 / 7;
                temp += pi; 
            }

            return temp / n;
        }

        static long GetNumber(string prompt)
        {
            long output;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (Int64.TryParse(input, out output))
                {
                    return output;
                }
            }
        }
    }
}