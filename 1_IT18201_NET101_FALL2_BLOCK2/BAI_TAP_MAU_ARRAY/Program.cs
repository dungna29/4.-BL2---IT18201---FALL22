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
            //HocCachXemCacBuocTrongGiaiThuat();
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

        static void TimPhanTuTheoIndex()
        {
            Console.Write("Mời bạn nhập Index: ");
            _input = Console.ReadLine();
            Console.WriteLine($"Index: {_input} - Value: {_arrMsv[Convert.ToInt32(_input)]}");
        }

        static void TimiemTuyetDoi()
        {
            Console.Write("Mời bạn nhập MSV: ");
            _input = Console.ReadLine();
            //int flag = 1;
            for (int i = 0; i < _arrMsv.Length; i++)
            {
                if (_arrMsv[i] == _input)
                {
                    Console.WriteLine($"Index: {_input} - Value: {_arrMsv[i]}");
                    //flag = 0;
                    return;
                }
            }

            Console.WriteLine("Không tìm thấy");
            //if (flag == 1)
            //{
            //    Console.WriteLine("Không tìm thấy");
            //}
            //Muốn in cả không tìm thấy
        }

        static void Sort()
        {
            // 5 3 7 9
            int[] arrNumbers = new[] { 5, 3, 7, 9 };
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                for (int j = i + 1; j < arrNumbers.Length - 1; j++)
                {
                    if (arrNumbers[i] > arrNumbers[j])
                    {
                        int temp = arrNumbers[i];
                        arrNumbers[i] = arrNumbers[j];
                        arrNumbers[j] = temp;
                    }
                }
            }
            //In mảng sau khi sắp xếp
            foreach (var x in arrNumbers)
            {
                Console.Write(x + " ");
            }
        }

        static void HocCachXemCacBuocTrongGiaiThuat()
        {
            //1. Viết ra giấy trên từng lần chạy hoặc word hoặc excel
            //2. 1 Cách thông minh hơn
            int[] arrNumbers = { 9, 8, 7, 6, 5 };
            foreach (var x in arrNumbers)
            {
                Console.Write(x + " ");
            }
            /*
             * 9, 8, 7, 6, 5
             * Vòng 1 - i = 0;
             * index[i] = 9 > index[j]1 = 8
             * 8, 9, 7, 6, 5
             * index[i] = 8 > index[j]2 = 7
             * 7, 9, 8, 6, 5
             * index[i] = 7 > index[j]3 = 6
             * 6, 9, 8, 7, 5
             * index[i] = 6 > index[j]4 = 5
             * 5, 9, 8, 7, 6
             * Vòng 2 - i = 1;
             * index[i] = 9 > index[j]2 = 8
             * 5, 8, 9, 7, 6
             * index[i] = 8 > index[j]3 = 7
             * 5, 7, 9, 8, 6
             * index[i] = 7 > index[j]4 = 6
             * 5, 6, 9, 8, 7
             * Vòng 3 - i = 2;
             * index[i] = 9 > index[j]3 = 8
             * 5, 6, 8, 9, 7
             * index[i] = 8 > index[j]4 = 7
             * 5, 6, 7, 9, 8
             * Vòng 4 - i = 3;
             * index[i] = 9 > index[j]4 =8
             * 5, 6, 7, 8, 9
             */
            // for (int i = 0; i < arrNumbers.Length - 1; i++)
            // {
            //     for (int j = i + 1; j < arrNumbers.Length; j++)
            //     {
            //         if (arrNumbers[i] > arrNumbers[j])
            //         {
            //             int temp = arrNumbers[i];
            //             arrNumbers[i] = arrNumbers[j];
            //             arrNumbers[j] = temp;
            //         }
            //     }
            // }

            for (int i = 0; i < arrNumbers.Length - 1; i++)
            {
                Console.WriteLine("Lần chay thứ: " + i);
                foreach (var x in arrNumbers)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine("");
                for (int j = i + 1; j < arrNumbers.Length; j++)
                {
                    Console.Write("Điều kiện {0} > {1} \n", arrNumbers[i], arrNumbers[j]);
                    if (arrNumbers[i] > arrNumbers[j])
                    {
                        int temp = arrNumbers[i];
                        arrNumbers[i] = arrNumbers[j];
                        arrNumbers[j] = temp;
                        Console.Write("Hoán vị của:{0} & {1} \n", arrNumbers[i], arrNumbers[j]);
                        foreach (int x in arrNumbers)
                        {
                            Console.Write(x + " ");
                        }
                        Console.WriteLine("");
                    }
                }
            }
            Console.WriteLine();
            foreach (var x in arrNumbers)
            {
                Console.Write(x + " ");
            }
        }

    }
}
