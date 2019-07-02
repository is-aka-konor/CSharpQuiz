using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CSharpQuiz.Questions._BonusQuestion_1.Models;

namespace CSharpQuiz.Questions._BonusQuestion_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            using (var db = new BloggingContext())
            {
                IEnumerable<string> titles = (IEnumerable<string>)(from p in db.Post 
                                            //where p.Title.StartsWith("search")
                                            select p.Title);
                foreach (var title in titles.Where(t => t.StartsWith("Search")))
                {
                    Console.WriteLine(title);
                }
            }
            stopwatch.Stop();

            Console.WriteLine($"Search finished in {stopwatch.Elapsed}");
            Console.ReadLine();
        }
    }
}
