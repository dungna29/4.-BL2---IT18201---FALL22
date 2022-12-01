using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_KeThua
{
    /*
     * 1. Để sử dụng kế thừa thì dùng dấu :
     * 2. C# và JAVA là đơn kế thừa.
     * 3. Khi lớp con kế thừa sẽ được thừa hưởng lại toàn bộ các thuộc tính, phương thức mà lớp cha cho phép.
     * 4. Khi kế thừa thì lớp con sẽ trở thành lớp cha.
     */
    internal class SinhVien:Nguoi //Sinh viên kế thừa lớp cha Nguoi
    {
        private string msv;
        private string nganhHoc;
        //Lớp con chỉ cần khai báo các thuộc tính đặc trưng riêng của đối tượng.
        public SinhVien()
        {

        }
        //Tạo contructor có tham số
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Contructor 'ClassCon(Bên trong có tham số của thuộc tính cha)
        //3. Bôi vào các thuộc tính của con -> Quick Actions -> Add Parameter to contructor -> Chọn cái contructor có tham số vừa Generate ra.
        public SinhVien(string id, string namSinh, string ten, string diaChi, string sdt, string msv, string nganhHoc) : base(id, namSinh, ten, diaChi, sdt)
        {
            this.msv = msv;
            this.nganhHoc = nganhHoc;
            //this: Dùng để tham chiếu đến thuộc thính hoặc phương thức của lớp hiện tại.
            //base: Dùng để tham chiếu đến thuộc thính hoặc phương thức của lớp cha.
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string NganhHoc
        {
            get => nganhHoc;
            set => nganhHoc = value;
        }
        //Tính đa hình trong OOP
        //Muốn kế thừa phương thức của lớp cha
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Overrides sau đó chọn phương thức các bạn muốn kế thừa
        //3. Khi kế thừa lại phương thức của lớp cha thì phương thức đặt tại lớp con có thể code lại nội dung bên trong thì hành động này gọi là ghi đè phương thức.
        public override void InRaManHinh()
        {
            Console.WriteLine("Đây là method của con");
            //Code lại bên trong
        }

    }
}
