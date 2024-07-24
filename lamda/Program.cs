using System;


namespace lamda
{
    public class Program
    {
        static void Main(string[] main)
        {
            Action<string> thongbao;
            thongbao = (string s) => System.Console.WriteLine(s);

            thongbao.Invoke("xin chào");
            
        }
    }
}
