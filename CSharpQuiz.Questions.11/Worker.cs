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
            Console.WriteLine($"The counter is {counter}");
        }

        private void Updater(int accumulator)
        {
            Console.WriteLine($"The accumulator is {accumulator}");
            ++accumulator;
            Console.WriteLine($"The accumulator is {accumulator}");
        }
    }
}
