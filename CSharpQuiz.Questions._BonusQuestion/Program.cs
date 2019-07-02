using System;
using System.Runtime.InteropServices;

namespace CSharpQuiz.Questions._BonusQuestion
{
    class Program
    {
       static void Main(string[] args)
       {
            var size1 = Marshal.SizeOf(typeof(MyClass1));
            var size2 = Marshal.SizeOf(typeof(MyClass2));
            var str = size1 == size2 ? "I know" : "I knew";
            Console.WriteLine($"{str} size of MyClass1 {size1} size of MyClass2 {size2}");

            long StopBytes = 0;
           MyClass1 myClass1;
           MyClass2 myClass2;
           long StartBytes = System.GC.GetTotalMemory(true);
           myClass1 = new MyClass1();
           StopBytes = System.GC.GetTotalMemory(true);
           //GC.KeepAlive(myClass1); // This ensure a reference to object keeps object in memory

           Console.WriteLine($"Size is {(long)(StopBytes - StartBytes)}");
           StartBytes = System.GC.GetTotalMemory(true);
           myClass2 = new MyClass2();
           StopBytes = System.GC.GetTotalMemory(true);
           //GC.KeepAlive(myClass2); // This ensure a reference to object keeps object in memory
           Console.WriteLine($"Size is {(long)(StopBytes - StartBytes)}");
           Console.ReadLine();
       }
    }

       //[StructLayout(LayoutKind.Sequential)]
       struct MyClass1
       {
           public char Char { get; set; }
           public byte Byte { get; set; }
           public long Long { get; set; }
           public int Int1 { get; set; }
           public long Long1 { get; set; }
           public char Char1 { get; set; }
           public byte Byte1 { get; set; }
           
          
           public int Int { get; set; }

           
           
       }

       //[StructLayout(LayoutKind.Sequential)]
       struct MyClass2
       {
           public long Long1 { get; set; }
           public long Long { get; set; }
           public int Int1 { get; set; }
           public int Int { get; set; }
           public char Char1 { get; set; }
           public char Char { get; set; }
           public byte Byte { get; set; }
           public byte Byte1 { get; set; }
       }
}
