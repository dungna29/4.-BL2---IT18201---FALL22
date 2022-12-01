using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_AccessModifier
{
    internal class Program
    {
        /*
         * AccessModifier: sử dụng trên biến, phương thức, class
         * Public: Được phép truy cập ở tất cả các lớp
         * Private: Chỉ được phép sử dụng bên trong class đó.
         * Protected: Chỉ cho phép lớp con mới có quyền truy cập và trong cùng 1 class vẫn truy cập.
         * Internal: Chỉ được truy cập bên trong 1 thư mục.
         *
         * Ngoài ra còn 2 sự kết hợp: protected internal, private protected
         */
        class SinhVien
        {
            private string att1;//private
            public string att2;//public
            string att3;//default = private
            protected string att4;
            internal string att5;
            //Áp dụng cho method tương tự

        }

        class PTPM:SinhVien
        {
            public PTPM()
            {
                //att1 = "";
                att2 = "";
                //att3 = "";
                att4 = "";//Khi có kế thừa
                att5 = "";
            }
        }
        class MOB
        {
            public MOB()
            {
                SinhVien sv1 = new SinhVien();
                //sv1.att1 = "";
                sv1.att2 = "";
                //sv1.att3 = "";
                //sv1.att4 = "";//Khi có kế thừa
                sv1.att5 = "";
            }
        }
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            //sv1.att1 = "";
            sv1.att2 = "";
            //sv1.att3 = "";
            //sv1.att4 = "";//Khi có kế thừa
            sv1.att5 = "";
        }
    }
}
