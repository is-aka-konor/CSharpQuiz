using System;

namespace CSharpQuiz.Questions._11
{
    public class Worker
    {
        public void Run()
        {
            var counter = 1;
            Console.WriteLine($"The counter is {counter}");
            Updater(counter);
            Console.WriteLine($"The counter after update is {counter}");
            
            var newCounter = new Counter(counter);
            Console.WriteLine($"The new counter is {newCounter}");
            NewUpdater(newCounter);
            Console.WriteLine($"The new counter after update is {newCounter}");
        }

        private void Updater(int accumulator)
        {
            ++accumulator;
        }

        private void NewUpdater(Counter newCounter)
        {
            ++newCounter.Accumulator;
        }

        protected class Counter
        {
            public int Accumulator;

            public Counter(int startCounter)
            {
                Accumulator = startCounter;
            }

            public override string ToString()
            {
                return Accumulator.ToString();
            }
        }
    }
}
