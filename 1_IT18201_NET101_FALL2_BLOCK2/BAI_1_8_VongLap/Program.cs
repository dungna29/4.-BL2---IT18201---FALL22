using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_VongLap
{
    internal class Program
    {
        /*
        * BàiVòng lặp:
        *
        * Định nghĩa chung cho tất cả vòng lặp:
        * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
        *
        * Các loại vòng lặp: while, do..while, for, foreach
        *
        * Từ khóa sử dụng trong vòng lặp:
        *
        * break - ngắt vòng lặp
        * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
        *
        * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
        * + Cách dùng: wh + tab
        *
        * + Công thức:
        *  while (true)
           {
               //Thực thi 1 câu lệnh hoặc nhiều câu lệnh
           }
           Vòng lặp Do..While: Thực hiện hành động ít nhất là 1 lần. Điều kiện đề vòng lặp chạy giống như While(True).
          Cách gõ: do + tab
          Công thức:
          do {
                     //Thực hiện hành động ít nhất là 1 lần.
          } while (true);
           Cách gõ: for + tab
           Công thức:
            for (int i = 0; i < 10; i++) {
               }
           int i = 0: Điểm bắt đầu của vòng lặp có kiểu số nguyên
           i < 10: Điều kiện để ngắt vòng
           i++: Tăng bước nhẩy lên 1
  */
        static void Main(string[] args)
        {
            //Ví dụ: In ra 1 câu 5 lần
            /*
             * Bí kíp làm chủ vòng lặp:
             *  1. Điểm bắt đầu
             *  2. Điều kiện phải đúng
             *  3. Bước nhẩy
             */
            //1. for + tab
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Tôi sẽ qua môn C#1");
            //}

            //2. wh + tab
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Tôi sẽ qua môn C#1");
                i++;
            }

            //3. do + tab
            int j = 0;
            do
            {
                Console.WriteLine("Tôi sẽ qua môn C#1");
                j++;
            } while (j<5);

            //In Full Bảng Cửu Chương bằng Do hoặc While
        }
    }
}
