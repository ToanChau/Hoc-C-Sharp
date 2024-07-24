using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace baitap
{
    public class Baitap
    {

        public void DayFibonacci(int n)
        {
            int f0 = 0, f1 = 1, f2 = 1;
            if (n < 0)
            {
                Console.WriteLine("N be hon khong");

            }
            else if (n == 0 || n == 1)
            {
                System.Console.WriteLine(n);
            }
            else
            {
                System.Console.Write("0\t1\t1\t");
                for (int i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = f2;
                    f2 = f0 + f1;
                    System.Console.WriteLine(f2 + "\t");
                }
            }
        }
        public int timsofibonancci(int n)
        {
            if (n <= 1)
                return n;
            else
                return timsofibonancci(n - 1) + timsofibonancci(n - 2);
        }
        public void DayFibonacciDeQuy(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                System.Console.Write(timsofibonancci(i) + " ");

            }
        }
        public bool Kiemtrasonguyento(int n)
        {
            if (n < 2)
                return false;
            else if (n == 3 || n == 2)
                return true;
            else
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
        }
        public long Tinhgiaithua(int n)
        {
            long giaithua = 1;
            if (n == 0 || n == 1)
                return 1;
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    giaithua *= i;
                }
                return giaithua;
            }
        }
        public string Chuyenhe10sangheB(int n, int b)
        {
            if (n == 0)
                return "0";
            if (b > 16 || b < 2)
                return "Hệ số không hợp lệ";
            else
            {
                string heso = "0123456789ABCDF";
                string ketqua = "";
                while (n > 0)
                {
                    int sodu = n % b;
                    ketqua = heso[sodu] + ketqua;
                    n /= b;
                }
                return ketqua;
            }
        }
        public (double, double) Giaiphuongtrinhbac2(double a, double b, double c)
        {

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c != 0)
                        return (double.NaN, double.NaN);
                    else
                        return (double.PositiveInfinity, double.PositiveInfinity);
                }
                else
                    return (-b / c, -b / c);
            }
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
                return (double.NaN, double.NaN);
            else if (delta == 0)
                return (-b / 2 * a, -b / 2 * a);
            else
                return ((-b + Math.Sqrt(delta) / (2 * a)), (-b - Math.Sqrt(delta) / (2 * a)));
        }
        public void Chuanhoachuoi(string chuoi)
        {

            chuoi.Trim();
            while (chuoi.IndexOf("  ") != -1)
            {
                chuoi.Replace("  ", " ");
            }
            chuoi.ToLower();
            if (chuoi.Length > 0)
            {
                chuoi = char.ToUpper(chuoi[0]) + chuoi.Substring(1);
            }
            for (int i = 1; i < chuoi.Length - 1; i++)
            {
                if (chuoi[i].ToString() == " ")
                {
                    chuoi = chuoi.Substring(0, i + 1) + char.ToUpper(chuoi[i + 1]) + chuoi.Substring(i + 2);
                }
            }
        }


    }
}