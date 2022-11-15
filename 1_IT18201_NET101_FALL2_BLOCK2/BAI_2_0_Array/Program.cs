using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_Array
{
    internal class Program
    {
        /*
        * Phần 1: Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán.
        *
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Khai báo biến
            int a = 5;
            a = 6;

            //2. khai báo mảng
            int[] arrNumbers;//Khai báo 1 mảng số nguyên
            arrNumbers = new int[5];//Khởi tạo 1 mảng gồm 5 phần tử.

            string[] arrNames = new string[4];

            string[] arrNames1 = { "C#1", "C#2", "C#3" };
            string[] arrNames2 = new[]  { "C#1", "C#2", "C#3" };//Khai báo ngầm định
            string[] arrNames3 = new string[]  { "C#1", "C#2", "C#3" };//Khai báo tường minh

            var arrNames4 = new[] { "A","B"};
            var arrNames5 = new string[] { "A","B"};

            //3. Gán giá trị cho mảng thông qua index
            //arrNumbers = 5; Sai
            arrNumbers[0] = 5;//Gán giá trị 5 cho index 0
            arrNumbers[1] = 6;
            arrNumbers[2] = 7;
            arrNumbers[0] = 9;//Ghi đè lại giá trị tại index 0

            //4. Lấy giá trị: Gán giá trị vào index nào thì lấy ra đúng ở index đó.
            Console.WriteLine(arrNumbers[1]);

            //arrNumbers.Length: Độ dài của mảng có kiểu dữ liệu int
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }
        }
    }
}
