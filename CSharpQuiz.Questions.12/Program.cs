using System;

namespace CSharpQuiz.Questions._12
{
    class Program
    {
        public static readonly string str = "Current string is 1";

        static void Main(string[] args)
        {
            var str2 = "Current string is 1";
            Console.WriteLine(object.ReferenceEquals(str2, str));

            var counter = 1;
            str2 = $"Current string is {counter}";
            Console.WriteLine(object.ReferenceEquals(str2, str));

            Console.ReadKey();
        }
    }
}
