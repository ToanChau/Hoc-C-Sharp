using System;

namespace Delegate
{
    public delegate void Callback(string message);
    public class Program
    {
        static void missedcall(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }
        static void completedcall(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Callback callback = missedcall;
            
            callback.Invoke("hello");

        }
    }
}