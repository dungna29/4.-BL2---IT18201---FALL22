using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_CHUALAB1234
{
    internal class Program
    {
        /*
         Bài 0: In bảng cửu chương theo khoảng mà người dùng nhập vào.
         Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.

         Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điều thông báo Trượt hoặt đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.

         Bài 3: Viết 1 chương trình nhập nhiều  thông tin của sinh viên POLY. Mỗi sinh viên khi nhập vào cần các thông tin sau: Tên, Năm Sinh, Msv. Sau khi người dùng nhập xong hết thông tin sinh viên cần thêm thì sẽ in tất cả ra màn hình lưu in thêm tuổi của mỗi sinh viên tương ứng.(Gợi ý mỗi thuộc tính là một mảng)*/
        static void Main(string[] args)
        {
        }

        static void Bai0()
        {
            int k1, k2;
            Console.WriteLine("Mời bạn nhập K1: ");
            k1 = Convert.ToInt32(Console.ReadLine());//5
            Console.WriteLine("Mời bạn nhập K2: ");
            k2 = Convert.ToInt32(Console.ReadLine());//7
            if (k1 > k2)
            {
                int temp = k1;
                k1 = k2;
                k2 = temp;
            }
            for (int i = k1; i <= k2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i} x {j} ={i * j}");
                }
            }
        }

        static void Bai1()
        {
            int[] arrNumbers;
            int size;
            Console.WriteLine("Mời bạn nhập số lượng: ");
            size = Convert.ToInt32(Console.ReadLine());
            //Sau khi đã nắm số lượng phần tử người dùng muốn
            arrNumbers = new int[size];//Khởi tạo mảng
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine($"Mời bạn nhập giá tị tại: {i}: ");
                arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var x in arrNumbers)
            {
                if (x % 2 == 0)
                {
                    Console.Write(x + " ");
                }
            }

            Console.WriteLine();
            foreach (var x in arrNumbers)
            {
                if (x % 2 != 0)
                {
                    Console.Write(x + " ");
                }
            }

            Console.WriteLine();
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.Write(arrNumbers[i] + " ");
            }

            int a = 5;
            int b = a + 7;
            /*
             * arrNumbers[i] = Giá trị -> Kiểu dữ liệu
             */
        }
    }
}
