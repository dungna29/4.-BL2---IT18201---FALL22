using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_3_EpKieu
{
    internal class Program
    {/*
      * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
      *
      * Công thức ép kiểu tường minh:
      *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
      *
      * P2: Ép kiểu từ string về số
      *  + Phương thức Parse()
      *  + Lớp Convert()
      */
        static void Main(string[] args)
        {
            //Phần 1: Ví dụ ép kiểu và không ép kiểu
            string a, b;
            Console.WriteLine("Mời bạn nhập số a: ");
            a = Console.ReadLine();//11
            Console.WriteLine("Mời bạn nhập số b: ");
            b = Console.ReadLine();//2
            Console.WriteLine($"{a} + {b} = {a+b}");//112 - Cộng chuỗi
            Console.WriteLine($"{a} + {b} = {Convert.ToInt32(a) + Convert.ToInt32(b)}");//13
            Console.WriteLine($"{a} + {b} = {int.Parse(a) + int.Parse(b)}");//13

            //Phần 2: Chuyển đổi kiểu dữ liệu số với nhau
            int t1 = 8;
            double t2 = 9.9;
            t2 = t1;//8.0 - Ép kiểu tự dộng
            t2 = (double)t1;//8.0 - Ép kiểu tương mình
            //t1 = t2;//Lỗi vì kiểu dữ liệu t2 lớn hơn t1


        }
    }
}
