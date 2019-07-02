using System;

namespace CSharpQuiz.Questions._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EstimatedResponseTime(200, 2000));
            Console.WriteLine(EstimatedResponseTime(400, 4000));
            Console.ReadLine();
        }

        private static int EstimatedResponseTime(int numAuthsAndSales, int numRest)
        {
            return (int)(5 * 60 * 1000 + 2.5 * 1000 + numAuthsAndSales * (1 / 5) * 1000 + numRest * (1 / 50) * 1000) * 5;
        }
    }


}
