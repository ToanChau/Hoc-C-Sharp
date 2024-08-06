using System;

namespace LoiException
{
    class Program
    {
        // phát sinh Exception\
        static void kiemtratenvatuoi(string ten, int tuoi)
        {
            if (string.IsNullOrEmpty(ten))
            { 
               Exception exception = new Exception("Ten khong duoc de trong");
               throw exception;
            }
            if(tuoi < 18)
                throw new Exception("Ban chua du 18 tuoi");

            System.Console.WriteLine($"Xac nhan {ten} du {tuoi} tuoi");
        }

        public static void Main(string[] args)
        {
            // int a = 5;
            // int b = 0;
            // try
            // {
            //     var c = a / b;
            //     System.Console.WriteLine(c);
            // }
            // catch (DivideByZeroException e)
            // {
            //     System.Console.WriteLine(e.Message);
            //     System.Console.WriteLine("---------------------------------------");
            //     System.Console.WriteLine(e.ToString());
            //     System.Console.WriteLine("---------------------------------------");
            //     System.Console.WriteLine(e.HResult);
            //     System.Console.WriteLine("---------------------------------------");
            //     System.Console.WriteLine(e.TargetSite);
            //     System.Console.WriteLine("---------------------------------------");
            //     System.Console.WriteLine(e.Data);
            //     System.Console.WriteLine("---------------------------------------");
            //     System.Console.WriteLine(e.HelpLink);


            //     System.Console.WriteLine("Phep tinh bi loi");

            // }
            // catch (Exception e1)
            // {
            //     System.Console.WriteLine(e1.Message);
            // }
            // try
            // {
            //     string link = null;
            //     string text = File.ReadAllText(link);
            //     System.Console.WriteLine(text);
            // }
            // catch (FileNotFoundException nf)
            // {
            //     System.Console.WriteLine(nf.Message);
            //     System.Console.WriteLine("Khong tin thay file");
            // }
            // catch (ArgumentNullException ane)
            // {
            //     System.Console.WriteLine(ane.Message);
            //     System.Console.WriteLine("Khong co duong dan");
            // }
            // catch (Exception e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }
            try
            {
                kiemtratenvatuoi("toan",10);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}