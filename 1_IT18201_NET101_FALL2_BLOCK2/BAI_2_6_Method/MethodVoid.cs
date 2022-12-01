using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_Method
{
    internal class MethodVoid
    {
        /*
      *  Phương thức không trả về là : Void
      *   Công thức chung:
      *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
      *  {
      *          Body code
      *  }
      */
        public void TinhTong2So()//Phương thức không có tham số
        {
            int a, b;
            Console.WriteLine("Mời nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời nhập b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
        }
        //public void TinhTong2So()// Vì 2 phương thức giống nhau cả tên lẫn tham số.
        //{

        //}
        public void TinhTong()
        {
            int a, b;
            Console.WriteLine("Mời nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời nhập b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
        }
        public void TinhTong(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void TinhTong(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void TinhTong(int a, int b, string c)
        {
            Console.WriteLine(a + b + c);
        }
        //Ngoài ra tham số của phương thức rất đa dạng.
    }
}
