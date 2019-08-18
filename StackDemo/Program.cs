using System;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack demo");

            Stack.PrintStack();
            Stack.Push('u');
            Stack.PrintStack();
            Stack.Push('o');
            Stack.PrintStack();
            Stack.Push('i');
            Stack.PrintStack();
            Stack.PrintPeek();
            Stack.Push('e');
            Stack.PrintStack();
            Stack.Push('a');
            Stack.PrintStack();
            Stack.Pop();
            Stack.PrintStack();
            Stack.Pop();
            Stack.PrintStack();
            Stack.Pop();
            Stack.PrintStack();
            Stack.Pop();
            Stack.PrintStack();
            Stack.Pop();
            Stack.PrintStack();

            Console.ReadLine();
        }
    }
}
