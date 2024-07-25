using System;
using System.Collections.Generic;
using System.Linq; // Thêm không gian tên System.Linq để sử dụng ToList()

namespace lamda // Lamda - Biểu thức vô danh
{
    public class Program
    {
        static void Main(string[] args)
        {
            Action<string> thongbao;
            thongbao = (string s) => System.Console.WriteLine(s);
            // biểu thức lamda khi được tạo phải được gán cho 1 biến dạng delegate
            // có thể rút gon lại 
            thongbao = (chuoi) => System.Console.WriteLine(chuoi);
            // vì thongbao hiểu được kiểu của tham số

            //biểu thức lamda không có tham so
            Action none;
            none = () => {   
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Goi tu lamda khong tham so");
                Console.ResetColor();
            };

            thongbao?.Invoke("hello gọi từ lamda2");
            none?.Invoke();

            // kết hợp với thư viện ToList, foreach,....
            string[] mang = {"Nhi","Yeu","Dau"};
            mang.ToList().ForEach((string x) => { 
                if (x.Length>0) {
                     System.Console.WriteLine(x);
                }
                   
            });


            List<string> kq = mang.Where( (x) => x.Length>0).ToList();
            kq.ForEach((string x) => {System.Console.WriteLine(x);}) ;
        }
    }
}
