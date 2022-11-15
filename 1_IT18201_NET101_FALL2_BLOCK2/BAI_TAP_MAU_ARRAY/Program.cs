using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_ARRAY
{
    internal class Program
    {   /*
         * Bài tập Mẫu
         * 1. Nhập mảng
         * 2. Xuất mảng
         * 3. Tìm kiếm trong mảng theo index
         * 4. Sort mảng
         * 5. Thoát
         */
        private static string _input;
        private static string[] _arrMsv;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
        }

        static void Menu()
        {
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Nhập mảng");
                Console.WriteLine("2. Xuất");
                Console.WriteLine("3. Tìm kiếm theo index");
                Console.WriteLine("4. Sort");
                Console.WriteLine("5. Thoát");
                Console.Write("Mời bạn chọn CN: ");
                _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        NhapMang();
                        break;
                    case "2":
                        XuatMang();
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại.");
                        break;
                }
            } while (_input != "5");
        }

        static void NhapMang()
        {
            Console.Write("Mời bạn nhập số lượng: ");
            _input = Console.ReadLine();//Số lượng người dùng mong muộn
            _arrMsv = new string[Convert.ToInt32(_input)];//Khởi tạo được mảng với số phần tử người dùng mong muốn.
            for (int i = 0; i < _arrMsv.Length; i++)
            {
                Console.Write($"Mời bạn nhập giá trị tại index = {i}: ");
                _arrMsv[i] = Console.ReadLine();
            }

            _input = "0";
            Console.WriteLine("Bạn đã nhập xong giá trị");
        }
        static void XuatMang()
        {
            foreach (var x in _arrMsv)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }
    }
}
