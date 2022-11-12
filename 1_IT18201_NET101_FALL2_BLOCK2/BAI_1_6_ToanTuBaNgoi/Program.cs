using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_6_ToanTuBaNgoi
{
    internal class Program
    {
        /*
   * TOÁN TỬ 3 NGÔI
   * <Điều kiện hoặc nhiều điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
       */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string temp1 = 5 > 6 ? "Đúng" : "Sai";
            int temp2 = 5 > 6 ? 1 : 0;
            double temp3 = 5 > 6 ? 1.0 : 0.1;
            bool temp4 = 5 > 6 ? true : false;
            /*
          * Bài tập: Viết 1 chương trình khi nhập thông tin 1 người xác định được là ANH, CHỊ, EM Trai,Em Gái, BẠN
          * Cố định lại Tuổi và Giới Tính của bản thân
          */
            int nsBanThan = 2000, gioiTinh = 1;// 1= Nam: 0 Nữ
            int nsNguoi, gioiTinhNguoi;
            string ten;
            //Yêu cầu nhập năm sinh, tên, Giới tính và thực hiện câu chào. Phải sử dụng toán tử 3 ngôi.
            do
            {
                Console.Write("Mời bạn nhập tên: ");
                ten = Console.ReadLine();
                Console.Write("Mời bạn nhập ns: ");
                nsNguoi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập giới tính: ");
                gioiTinhNguoi = Convert.ToInt32(Console.ReadLine());

                // 1999 < 2000 và GT Nam = Anh
                string chao = ((nsNguoi < nsBanThan) && gioiTinhNguoi == 1) ? "Anh":
                    ((nsNguoi < nsBanThan) && gioiTinhNguoi == 0) ? "Chị":
                    ((nsNguoi > nsBanThan) && gioiTinhNguoi == 1) ? "Em Trai":
                    ((nsNguoi > nsBanThan) && gioiTinhNguoi == 0) ? "Em Gái": "Bạn";
                Console.WriteLine($"Chào {chao} {ten}");
            } while (true);
        }

    }
}
