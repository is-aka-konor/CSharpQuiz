using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpQuiz.Questions._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            CallApiA().Wait();
            CallApiB().Wait();
            stopwatch.Stop();
            var result1 = stopwatch.Elapsed;

            stopwatch.Restart();
            Task.WaitAll(CallApiA(), CallApiB());
            stopwatch.Stop();
            var result2 = stopwatch.Elapsed;

            stopwatch.Restart();
            Task.WaitAll(CallApiB(), CallApiA());
            stopwatch.Stop();
            var result3 = stopwatch.Elapsed;

            var dictionary = new Dictionary<string, TimeSpan>
            {
                {nameof(result1), result1}, {nameof(result2), result2}, {nameof(result3), result3}
            };

            var result = dictionary.OrderBy(r => r.Value).First();
            Console.WriteLine($"Fastest result {result.Key} {result.Value}");
            Console.ReadLine();
        }

        private static async Task CallApiA()
        {
            Thread.Sleep(10);
            await Task.Delay(100);
        }

        private static async Task CallApiB()
        {
            Thread.Sleep(10);
            await Task.Delay(200);
        }
    }
}
