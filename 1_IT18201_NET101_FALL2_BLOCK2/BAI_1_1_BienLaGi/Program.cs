using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_BienLaGi
{

    internal class Program
    { /*
         * Bài 1.1 Khai báo biến
         * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến được khở tạo trong bộ nhớ ảo khi chương trình khởi chạy.
         *
         * Công thức: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
         *      Khai báo nhiều biến có cùng kiểu dữ liệu trên cùng 1 dòng:
         *      <Kiểu dữ liệu> <Tên Biến1> = <Giá trị>, <Tên Biến2> = <Giá trị>, <tên biến n>;
         * 1. <Kiểu dữ liệu>
         *  + Số nguyên:sbyte, byte, long, int
         *  + Sô thực: float, double, decimal
         *  + Chuỗi hoặc ký tự: string, char
         *  + Logic: bool
         *  + var: nó có thể đại diện là tất cả các kiểu dữ liệu.
         * 2. <Tên Biến>
         *  + Quy tắc:
         *      - Tên biến phải có nghĩa
         *      - Có phân biệt chữ hoa chữ thường
         *      - Không bắt đầu bởi số, không dùng từ khóa
         *      - Cố gắng làm quen đặt tên biến với Tiếng Anh
         *  + Khai báo tên biến với 2 từ trở lên:
         *      - Cách 1: normal = firstname
         *      - Cách 2: CamelCase = FirstName, firstName
         *      - Cách 3: Under_Score = first_name, first_Name
         *  + Biến cục bộ: là biến được khai báo bên trong 1 hàm.
         *  + Biến toàn cục: là biến được khai báo bên ngoài hàm.
         *      - Khi khai báo biến toàn cục sử dụng dấu gạch dưới _ trước tên biến.
         *      - int _year = 1989;
         * 3.<Giá trị>
         *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
         *  + Giá trị phải đúng các quy tắc với kiểu dữ liệu
         *
         */
        private int _temp;//Biến toàn cục
        static void Main(string[] args)
        {
            //1. Chuỗi
            string name = "Hoang";//Khai báo 1 biến có kiểu dữ liệu là string và có giá trị khởi tạo ban đầu.
            string name2;//Khai báo 1 biến có kiểu dữ liệu là string và không khởi tạo giá trị ban đầu
            string name3, name4, name5 = "FPOLY";//Khai báo nhiều biến có cùng kiểu dữ liệu

            //2. Số nguyên
            int a;
            long a1=9;

            //3. Số thực
            double d1 = 9.2;

            //4. Kiểu dữ liệu ngầm định (Phải khởi tạo giá trị ngay khi khai báo,không thuể sử dụng làm biến toàn cục, không thể sử dụng làm tham số truyền vào của 1 phương thức)
            //var v0; Khai báo sai
            var v1 = 1;
            var v2 = "1";
            var v3 = '2';
            var v4 = 5.9;
            var v5 = true;

            //5. Logic
            bool b1 = false;

            //Tất cả các biến được khai báo bên trong 1 phương thức gọi là biến cục bộ.
        }
    }
}
