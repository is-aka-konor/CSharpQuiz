using System;

namespace CSharpQuiz.Questions._10
{
    class Program
    {
        private static DateTime date;
        static void Main(string[] args)
        {
            var result = date == null ? "Yep" : "Nope";
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
