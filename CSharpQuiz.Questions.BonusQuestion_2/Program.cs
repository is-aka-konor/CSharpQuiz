using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CSharpQuiz.Questions.BonusQuestion_2.Models;

namespace CSharpQuiz.Questions.BonusQuestion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            using (var db = new BloggingContext())
            {
                IEnumerable<string> titles = db.Post.Select(p => p.Title).AsEnumerable();
                var searchResult = titles.Where(t => t.StartsWith("Search")).ToList();
                searchResult.ForEach(r => Console.WriteLine(r));
            }
            stopwatch.Stop();

            Console.WriteLine($"Search finished in {stopwatch.Elapsed}");
            Console.ReadLine();
        }
    }
}
