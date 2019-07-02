using System;
using System.Collections.Generic;

namespace CSharpQuiz.Questions._8
{
    class Program
    {
        delegate void Printer();

        static void Main(string[] args)
        {
            var printers = new List<Printer>();
            var i = 0;
            for(; i < 10; ++i)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }

            Console.ReadKey();
        }
    }
}