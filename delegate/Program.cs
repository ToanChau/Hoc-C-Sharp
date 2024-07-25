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
        static void CallWrite(string message,Callback call)
        {
            System.Console.WriteLine("gọi từ CallWrite: ");
            call(message);
        }
        static string goituFunc(string message) => message;
        static void Main(string[] args)
        {
            Callback callback = missedcall;
            CallWrite("hello",callback);
            //hoặc
            CallWrite("hello",completedcall);//truyền thẳng phương thức có kiểu trả về giống delegate

            //Action không trả về  hoặc void
            Action<string> call = new Action<string>(completedcall);
            call.Invoke("gọi từ Action");

            // Func trả về kiểu cuối cùng
            Func<string ,string> callfromfunc = goituFunc;

            System.Console.WriteLine($"GOI TU callfromfunc {callfromfunc("hello")}");

        }
    }
}