using System;
using System.Collections.Generic;
namespace Kieudanhsach
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            //List - các phần tử cùng kiểu
            // List<int> ds1 = new List<int>();
            // ds1.Add(5);
            // ds1.Add(6);
            // ds1.AddRange(new int[] { 1, 2, 3 });
            // ds1.Insert(0, 19);

            // // foreach(int i in ds1)
            // //     System.Console.WriteLine(i);
            // //     System.Console.WriteLine(ds1.Capacity);

            // List<int> n = ds1.FindAll((e) => { return e < 19; });
            // foreach (int item in ds1)
            // {
            //     System.Console.WriteLine(item);
            // }
            // System.Console.WriteLine("---------------------------");
            // ds1.Sort((p1,p2)=>{
            //     if(p1<p2) return -1;
            //     if(p1==p2) return 0;
            //     return 1;
            // });
            //  foreach (int item in ds1)
            // {
            //     System.Console.WriteLine(item);
            // }

            //SortedList
            SortedList<string,int> ds2= new SortedList<string, int>();
            ds2["diem1"] = 1;
            ds2["diem2"] = 3;
            
            foreach(var key in ds2.Keys)
            {
                System.Console.WriteLine(ds2[key]);
            }

            





        }
    }
}