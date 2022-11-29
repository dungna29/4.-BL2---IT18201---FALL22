using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_CRUD_OOP_LIST
{
    internal class Program//Nơi để menu
    {
        /*
         *  CRUD BINGCHILLING
         *
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            BingchillingService blService = new BingchillingService();
            string input = "";
            do
            {
                Console.WriteLine("Menu BingChilling FPOLY");
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Tìm");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. In Ds");
                Console.WriteLine("7. Thoát");
                Console.Write("Mời bạn chọn chức năng: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        blService.ThemKem();
                        break;
                    case "2":
                        blService.SuaKem();
                        break;
                    case "3":
                        blService.XoaKem();
                        break;
                    case "4":
                        blService.TimKiemKem();
                        break;
                    case "5":
                        blService.Sort();
                        break;
                    case "6":
                        blService.InDsKem();
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            } while (input != "7");
        }
    }
}
