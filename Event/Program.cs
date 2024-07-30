using System;

namespace Event
{
    public delegate void Dlgate(string s);
    public class Program
    {
        // public static void Main(string[] args)
        // {

        //     SinhVien sv = new SinhVien();
        //     DoiTen dt = new DoiTen();
        //     dt.Doitenchosinhvien(sv,"toan");
        // }
    }
    public class DoiTen
    {
        public void Doitenchosinhvien(SinhVien sv, string s)
        {
            sv.doiten += Doiten;
            sv.HoTen = s;
        }
        public static void Doiten(string s)
        {
            System.Console.WriteLine($"Da doi ten thanh : {s}");
        }
    }
    public class SinhVien
    {
        public Dlgate doiten;
        private string hoTen;
        public string HoTen
        {
            get => hoTen;
            set
            {
                hoTen = value;
                doiten(value);
            }
        }

    }


}