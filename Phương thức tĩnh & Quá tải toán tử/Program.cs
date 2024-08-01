using System;

namespace PTTinhvaQuatai
{
    class CountNumber
    {
        public static int dulieutinh = 10;
        public static void Info()
        {
            System.Console.WriteLine("So lan truy cap:" + dulieutinh);
        }
        ~CountNumber()
        {
            System.Console.WriteLine("Huy");
        }
        public void Count()
        {
            dulieutinh++;
        }
    }

    // Readonly
    public class SinhVien
    {
        public readonly string name;
        public string Name
        {
            get => name;
        } //tên chỉ đọc, không thể gán
        public SinhVien(string name)
        {
            this.name = name;
        }
        public SinhVien()
        {
            name = "Nhidangyeu";
        }
    }

    // Quá tải toán tử
    public class Vector
    {
        double x, y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Info()
        {
            System.Console.WriteLine($"Toa do x: {x}  y: {y}");
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }
        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        this.x = value;
                        break;
                    case 1:
                        this.y = value;
                        break;
                    default:
                        throw new Exception("Chi so sai");
                }
            }
            get
            {
                switch (i)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    default:
                        throw new Exception("Chi so sai");
                }
            }


        }
    }



public class Program
{
    public static void Main(string[] args)
    {
        Vector vt2 = new Vector(1, 3);
        Vector vt1 = new Vector(1, 3);

        Vector vt = vt1 + vt2;
        vt[0]=4;
        vt.Info();
        

    }
}

}