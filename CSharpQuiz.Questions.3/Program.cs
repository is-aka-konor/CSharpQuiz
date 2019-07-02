using System;

namespace CSharpQuiz.Questions._3
{
    class Program
    {
        static void Main(string[] args)
        {
            new MyClass("first", "last");
            Console.ReadLine();
        }
    }

    internal class MyClass
    {
        private readonly string _myFirstName = "Sergey";
        private readonly string _myLastName = "Idelson";

        public MyClass(string name, string surname):this(name)
        {
            _myLastName = surname;
            PrintMyName();
        }
        public MyClass(string name):this()
        {
            _myFirstName = name;
            PrintMyName();
        }

        public MyClass()
        {
            _myFirstName = "segrey";
            _myLastName = "ideslon";
            PrintMyName();
        }

        private void PrintMyName()
        {
            Console.WriteLine($"My name is {_myFirstName} {_myLastName}");
        }
    }
}
