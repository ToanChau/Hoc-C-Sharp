using System;

namespace IDisponsable
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var a = new A())
            {
                System.Console.WriteLine("Do something...");
            }
        }
    }
    public class A : IDisposable
    {
        bool resource = true;
        public void Dispose()
        {
            System.Console.WriteLine("Gọi khi hết using");
        }
        ~A()
        {
            resource = false;
        }
    }
    
}