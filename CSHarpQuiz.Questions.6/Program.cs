using System;
using System.Threading.Tasks;

namespace CSharpQuiz.Questions._6
{
    class Program
    {
        private static string result;
        static void Main(string[] args)
        {
            Print();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static async Task<string> Print()
        {
            await Task.Delay(5);
            result = "Printing is done";
            return "success";
        }
    }

}
