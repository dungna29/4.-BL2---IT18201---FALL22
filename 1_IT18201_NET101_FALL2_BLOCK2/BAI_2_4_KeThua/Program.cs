using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * 1. Khi kế thừa thì lớp con có đầy đủ các thuộc tính và phương của lớp cha cho phép.
            * 2. Khi sử dụng contructor lớp con sẽ vẫn đầy đủ các thuộc tính mà nó được kế thừa.
              3. C#2 trở lên khi nói về kế thừa có nghĩa biến lớp con trở thành chính lớp cha và tự phát triển riêng các thuộc tính và phương thức.
            */
            SinhVien sv1 = new SinhVien();
            sv1.Ten = "FPOLY";//Thuộc tính đc kế thừa
            sv1.Msv = "PH123";//Thuộc tính riêng đối tượng
            Nguoi n1 = new Nguoi();
            n1.InRaManHinh();//Phương thức cha
            sv1.InRaManHinh();//Phước thức con kế thừa
        }
    }
}
