using System;

namespace CSHarpQuiz.Questions._7
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            for (; i < 5; ++i)
            {
                for (var j = 5; j > i; --j)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
