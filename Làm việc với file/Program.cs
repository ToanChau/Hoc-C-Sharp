using System;
using System.Text;
namespace FileExample
{
    public class Produce
    {
        public Produce(int ma, double gia, string ten)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.Gia = gia;

        }
        public int Ma { get; set; }
        public double Gia { get; set; }
        public string Ten { get; set; }

        public void Save(Stream filestream)
        {

            byte[] Byte_Ma = BitConverter.GetBytes(Ma); // Chuyển Mã từ int --> byte;
            filestream.Write(Byte_Ma, 0, 4); //Ghi Mã dạng byte vào filestream với int nên có 4 byte;

            byte[] Byte_Gia = BitConverter.GetBytes(Gia); //Chuyển Giá từ double --> byte;
            filestream.Write(Byte_Gia, 0, 8); //Ghi Giá dạng byte vào filestream với double có 8 byte;

            byte[] Byte_Ten = Encoding.UTF8.GetBytes(Ten); //Chuyển Tên từ string --> byte dùng Encoding;
            byte[] Byte_Length = BitConverter.GetBytes(Byte_Ten.Length);//Chuyển độ dài của Byte_Ten(int) --> Byte;
            filestream.Write(Byte_Length, 0, 4);//Lưu Độ dài của Byte_Ten vào filestream với độ dài của int là 4; 
            filestream.Write(Byte_Ten, 0, Byte_Ten.Length); //Ghi tên dạng byte vào filestream với độ dài tùy thuộc vào Tên;


            filestream.Seek(0, SeekOrigin.Begin);//Di chuyển con trỏ về vị trí bắt đầu
                                                 // Seek(long offset, SeekOrigin origin):
                                                 // offset: Số byte mà bạn muốn di chuyển con trỏ.
                                                 // origin: Điểm gốc để bắt đầu di chuyển, có thể là một trong các giá trị:
                                                 // SeekOrigin.Begin: Bắt đầu từ đầu stream.
                                                 // SeekOrigin.Current: Bắt đầu từ vị trí hiện tại của con trỏ trong stream.
                                                 // SeekOrigin.End: Bắt đầu từ cuối stream.

        }
        public void Restore(Stream filestream)
        {
            var Byte_Ma = new Byte[4];
            filestream.Read(Byte_Ma, 0, 4);
            this.Ma = BitConverter.ToInt32(Byte_Ma, 0); //Đọc lại Mã từ byte --> int;

            var Byte_Gia = new byte[8];
            filestream.Read(Byte_Gia, 0, 8);
            this.Gia = BitConverter.ToDouble(Byte_Gia, 0); //Đọc lại Giá từ byte --> double;

            var Byte_Length = new byte[4];
            filestream.Read(Byte_Length, 0, 4);
            int Length = BitConverter.ToInt32(Byte_Length, 0);

            var Byte_Ten = new byte[Length];
            filestream.Read(Byte_Ten, 0, Length);
            this.Ten = Encoding.UTF8.GetString(Byte_Ten);
        }
    }
    static class Program
    {

        public static void ListFileDirectory(string path)
        {
            var directories = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                System.Console.WriteLine(file);
            }
            foreach (var directory in directories)
            {
                System.Console.WriteLine(directory);
                ListFileDirectory(directory);//Gọi đệ quy để đi vào thư mục con và tiếp tục đọc file
            }
        }
        public static string doi(this string path, string doi)
        {
            return path = Path.ChangeExtension(path, doi);
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //StreamFile
            using var stream = new FileStream(path: "data.dat", FileMode.Open);
            Produce sp = new Produce(1, 123, "khautrang");

            sp.Save(stream);
            sp.Restore(stream);
            System.Console.WriteLine($"{sp.Ma}/{sp.Ten}/{sp.Gia}");



            //var drives = DriveInfo.GetDrives();
            //foreach (var drive in drives)
            //{
            // Ổ đĩa

            // System.Console.WriteLine($"Drive: {drive.Name}");
            // System.Console.WriteLine($"Drive type {drive.DriveType}");
            // System.Console.WriteLine($"Label: {drive.VolumeLabel}");
            // System.Console.WriteLine($"Size: {drive.TotalSize}");
            // System.Console.WriteLine($"Free: {drive.TotalFreeSpace}"); 

            //}

            // Thư mục - Directory
            // string path= "obj";
            // Directory.CreateDirectory(path);//Tạo thư mục mới
            // System.Console.WriteLine(Directory.Exists(path));//Kiểm tra thư mục có tồn tại không;
            // var files = Directory.GetFiles(path);//Lấy các file trong thư mục "Path";
            // System.Console.WriteLine("Lấy file trong thư mục");
            // foreach(var file in files)
            // {
            //     System.Console.WriteLine(file);
            // }

            // var directories = Directory.GetDirectories(path);//Lấy các thư mục trong thư mục "Path";
            // System.Console.WriteLine("Lấy thư mục trong thư mục");
            // foreach(var directory in directories)
            // {
            //     System.Console.WriteLine(directory);
            // }

            // //ví dụ hàm ListFileDirectory
            // ListFileDirectory("vidulistfiledirectory");



            //Đường dẫn - Path
            // System.Console.WriteLine(Path.DirectorySeparatorChar);//Lấy kí tự phân cách;
            // var path = Path.Combine("Ketnoiduongdan", "kndd.txt");//Kết nối chuỗi thành đường dẫn;
            // path = path.doi("md");
            // System.Console.WriteLine(path);
            // System.Console.WriteLine(Path.GetDirectoryName(path));//Lấy đường dẫn tới file có tên path;
            // System.Console.WriteLine(Path.GetFullPath(path));//Lấy đường dẫn đầy đủ
            // System.Console.WriteLine(Path.GetExtension(path));//Lấy phần mở rộng của file;
            // var path2 = Path.GetRandomFileName();//Tạo file tên ngẫu nhiên;
            // var temp = Path.GetTempFileName();//Tạo file rỗng tạm thời;


            //File
            // string filename = "ABC.txt";
            // string content ="Đây là file mới";
            // File.WriteAllText(filename,content);//Ghi chuỗi vào file - Ghi đè;
            // File.AppendAllText(filename,"\nĐây là nội dung mới");
            // Console.WriteLine(File.ReadAllText(filename));
            // File.Move(filename,"123.txt");
            // File.Create("Taofiletucreate");


        }
    }
}