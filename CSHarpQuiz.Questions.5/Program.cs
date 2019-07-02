using System;

namespace CSHarpQuiz.Questions._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Name", null);
            var fn = person.FamilyName.Substring(person.Age - person.FamilyName.Length + 2
                    , nameof(person.FamilyName).Length - nameof(person.Name).Length) ;
            Console.WriteLine($"My name is {person.Name} {fn} and my age is {person.Age}");
            Console.ReadLine();
        }
    }

    class Person
    {
        public readonly string Name = "MyName";
        public const string FamilyName = "MyFamilyName";
        public readonly int Age = 12;

        public Person(string name, int? age = null)
        {
            Name = name;
            Age = age ?? Age;
        }
    }
}
