using System;

namespace CSharpQuiz.Questions._9
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MySuperClass(5);
            myClass.PrintValue();
            Console.ReadLine();
        }
    }

    class MySuperClass
    {
        public static int Value { get; set; }

        static MySuperClass()
        {
            if (Value == 0) Value = 10;
        }
        public MySuperClass()
        {
            if (Value == 0) Value = 5;
        }
        public MySuperClass(int value): this()
        {
            if (Value == 0) Value = value;
        }

        public void PrintValue()
        {
            if (Value == 5) Value = 6;
            Console.WriteLine($"Value {Value}");
        }
    }
}
