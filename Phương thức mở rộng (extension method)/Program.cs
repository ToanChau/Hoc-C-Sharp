using System;
using MyLib;
 
namespace ExtensionMethod
{

    public static class ABC
    {
        //tham số đầu tiên của lớp nào thì mở rộng cho lơp đó
        // ví dụ ở đây là mở rộng cho string
        public static void Print(this string s,ConsoleColor mau)
        {
            Console.ForegroundColor = mau;
            System.Console.WriteLine(s);
        }

    }
    public class Program
    {
        
        public static void Main(string[] args)
        {
            string s ="i love you";
            s.Print(ConsoleColor.DarkCyan);
            double y =10;
            double x = 10;
            System.Console.WriteLine();
        }
    }
}
