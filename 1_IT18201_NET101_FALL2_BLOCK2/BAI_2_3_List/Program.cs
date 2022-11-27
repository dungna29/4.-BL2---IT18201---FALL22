using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Phần 1: Khao báo và khởi tạo
            List<int> lstNumbers;//Khai báo 1 List số nguyên
            lstNumbers = new List<int>();//Khởi tạo List số nguyên.

            List<int> lstNumbers1 = new List<int>();
            List<SinhVien> lstSinhViens = new List<SinhVien>();// 1 List sinh viên
            SinhVien[] arrSinhViens = new SinhVien[6];

            //Phần 2: Gán giá trị
            lstNumbers.Add(2023);
            lstNumbers.Add(2024);

            //Phần 3:Lấy giá trị
            Console.WriteLine(lstNumbers[0]);//In giá trị của phần tử ở index 0

            foreach (var x in lstNumbers.Where(c=>c%2 == 0))
            {
                Console.Write(x + " ");
            }

            //Phần 4: 1 Vài phương thức ăn sẵn
            lstNumbers.RemoveAt(1);
            lstNumbers.Clear();
            lstNumbers.Sort();// Sort asc

            //LINQ
        }

        public class SinhVien
        {

        }
    }
}
