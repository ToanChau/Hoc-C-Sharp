using System;

namespace EventHandlers
{
    class Dulieunhap : EventArgs
    {
        public int data { set; get; }
        public Dulieunhap(int x) => data = x;

    }
    class UserInput
    {
        public event EventHandler sukiennhapso = (object? sender,EventArgs x)=>
            System.Console.WriteLine($"Ban vua nhap so: {((Dulieunhap)x).data}");
        public void Input()
        {
            do
            {
                System.Console.Write("Nhap vao so nguyen: ");
                int i = Int32.Parse(Console.ReadLine()); 
                sukiennhapso?.Invoke(this, new Dulieunhap(i));
            } while (true);
        }
    }
    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += Can;
        }
        public void Can(object senderm, EventArgs e)
        {
            Dulieunhap dlnhap= (Dulieunhap)e;
            int i  =dlnhap.data;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Can bac hai cua {i} la {Math.Sqrt(i)}");
            Console.ResetColor();
        }
    }
    class BinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += TinhBinhPhuong;
        }
        public void TinhBinhPhuong(object sender, EventArgs e)
        {
            Dulieunhap dlnhap = (Dulieunhap)e;
            int i = dlnhap.data;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Binh Phuong cua {i} la {Math.Pow(i, 2)}");
            Console.ResetColor();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.CancelKeyPress+=(sender,e)=>
            {
                System.Console.WriteLine("Thoat ung dung");
            };
            UserInput userInput = new UserInput();
            TinhCan tinhCan = new TinhCan();
            BinhPhuong binhPhuong = new BinhPhuong();
            tinhCan.Sub(userInput);
            binhPhuong.Sub(userInput);
            userInput.Input();
        }
    }
}