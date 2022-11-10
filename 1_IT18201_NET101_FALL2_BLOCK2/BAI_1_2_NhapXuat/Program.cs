using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_NhapXuat
{
    internal class Program
    {/*
         * BÀI 1.2 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
         *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Ví dụ: Nhập tên và năm sinh sau đó in ra màn hình

            //Bước 1: Xác định số lượng biến cần sử dụng
            string name;
            int year;

            //Bước 2: Hướng dẫn người dùng nhập
            Console.WriteLine("Mời bạn nhập tên: ");
            name = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập năm sinh: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Bước 3: Thực thi
            Console.WriteLine($"Tên: {name} + Năm sinh: {year} +  Tuổi: {2022 - year}");

        }
    }
}
