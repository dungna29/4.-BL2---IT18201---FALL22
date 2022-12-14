using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_5_CauLenhReNhanh
{
    internal class Program
    {/*
        * Bài 1.5 Câu điều kiện rẽ nhánh IF
        * ĐƯợc sử dụng để lập điều kiện và sẽ thực thi 1 hành động nào đó nếu thỏa mãn điều kiện.
    *
        * Công thức IF: if + tab
        *   if (<Điều kiện>)
    {
        If phải luôn đúng
        Một hành động được thi khi thỏa mãn điều kiện
    }
    */
    /*
    * Bài 1.6 Cầu điều kiện IF...ELSE (Nếu Thì)
    * Dùng để thực hiện 1 hành động nếu IF(TRUE) và ngược lại sẽ vào Else.
    *
    * Cấu trúc:
    * if (true)
       {
           Nếu mà If true thì sẽ thực hiện 1 hành động nào đó
       }
       else
       {
           Nếu không thỏa mãn IF thì mặc định là vào ELSE
       }
    */

    /*
   * Bài  1.7 Cầu điều kiện Else If dùng trong trường hợp có nhiều điều kiện khác nhau và thực hành động tương ứng với từng điều kiện. Else If phải luôn True thì mới thực hiện hành động bên trong nó.
   *
   * Lưu ý: Nếu thỏa mãn 1 điều kiện thì nó chỉ thực hiện hành động trong điều kiện đó mà thôi.
   *
   * Công thức:
   *   if (true)
      {
          //Thực hiện 1 hành động nếu If đúng
      }else if (<Điều kiện 1>)
      {
          //Khi If không thỏa mãn và Else If phải true thì mới vào đây thực hiện 1 hành động.
      }else if (<Điều kiện 2>)
      {
          //Tương tự
      }else
      {
          //Khi tất cả các điều kiện ở trên không thỏa mãn thì sẽ vào đây
      }
   */
        static void Main(string[] args)
        {
            double diemCsharp1 = 4.9;
            //if + tab
            if (diemCsharp1 >= 5)
            {
                Console.WriteLine("Chúc mừng bạn đã qua môn");
                return;//Ngắt toàn bộ phương thức
            }

            Console.WriteLine("Chúc mừng bạn đã mất 672k");

            //Else: Ngược lại mọi trường hợp
            if (diemCsharp1 >=5)
            {
                Console.WriteLine("Chúc mừng bạn đã qua môn");
            }
            else
            {
                Console.WriteLine("Chúc mừng bạn đã mất 672k");
            }

            //Else If:
            /* Ví dụ: Nếu qua môn C#1
                5 đến 6 = Iphone 8
                6 đến 8 = Iphone XS MAX
                8 đến 10 = Iphone 14
            Sử dụng If Else  - Không được dùng Return, không được dùng chỉ if không. Bắt buộc dùng If Else
            */
            if (diemCsharp1 >=5 && diemCsharp1 < 6)
            {
                Console.WriteLine("Iphone 8");
            }
            else
            {
                if (diemCsharp1 >= 6 && diemCsharp1 < 8)
                {
                    Console.WriteLine("Iphone XS");
                }
                else
                {
                    Console.WriteLine("Iphone 14");
                }
            }

            if (diemCsharp1 >= 5 && diemCsharp1 < 6)
            {
                Console.WriteLine("Iphone 8");
            }else if (diemCsharp1 >= 6 && diemCsharp1 < 8)
            {
                Console.WriteLine("Iphone XS");
            }else if (diemCsharp1 >= 8 && diemCsharp1 <= 10)
            {
                Console.WriteLine("Iphone 14");
            }
            else
            {
                Console.WriteLine("1 Túi đồ nghề đánh giày");
            }

        }
    }
}
