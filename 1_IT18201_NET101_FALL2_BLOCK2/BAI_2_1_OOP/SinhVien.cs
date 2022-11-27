using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_OOP
{
    //class = lớp
    //SinhVien = Đối tượng
    //Đối tượng là danh từ và phải viết hoa chữ cái đầu của từ. (BẮT BUỘC)
    internal class SinhVien
    {
        //Phần 1: Khai báo tất cả các thuộc tính mà đối tượng cần phải có (Phụ thuộc đầu bài).
        private string ten;
        private string msv;
        private string queQuan;
        private int ns;
        private int gt;//1 = Nam , 0 = Nữ
        private string truongHoc = "FPOLY";

        //Phần 2: Constructor - Hàm tạo
        /*
         * 1 - Constructor giống tên class.
         * 2 - Constructor là thành phần được chạy vào đầu tiên khi khởi tạo đối tượng
         * 3 - Khi mới học thì mỗi class đối tượng luốn có 2 Constructor (Có tham số, không tham số)
         * 4 - Nếu không tạo Constructor thì khi khởi tạo đối tượng bên bên ngoài thì sẽ sẽ luôn được ra 1 Constructor ngầm định không tham số.
         */
        //Constructor không tham số: ctor + tab
        public SinhVien()
        {
            Console.WriteLine("Chạy vào Constructor không tham số");
        }
        //Constructor có tham số dùng để gán giá trị cho thuộc tính ngay khi khởi tạo đối tượng
        /*
       Nếu bạn nào dùng resharper ctorf + tab
       Đối với các bạn không cài resharper muốn gọi contructor có tham số:
          1. Chuột phải vào Class đối tượng chọn Quick Actions....
          2. Generate Contructor và bấm ok
       */
        public SinhVien(string Ten1, string msv, string queQuan, int ns, int gt)
        {
            ten = Ten1;
            this.msv = msv;
            this.queQuan = queQuan;
            this.ns = ns;
            this.gt = gt;
            //this: Dùng để tham chiếu đến thuộc tính hoặc phương của lớp hiện tại.
        }
        //Phần 3:Triển khai property của thuộc tính vì các thuộc tính bị private không thể truy cập trự tiếp
        /*
         * Bôi đen vào các thuộc tính đang có hiện tại của lớp sau đó chuột phải --> Quick Actions....
         * Chọn Encapsulate fields
         *
         */
        //public TYPE Type { get; set; } prop + tab
        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string QueQuan
        {
            get => queQuan;
            set => queQuan = value;
        }

        public int Ns
        {
            get => ns;
            set => ns = value;
        }

        public int Gt
        {
            get => gt;
            set => gt = value;
        }

        public string TruongHoc
        {
            get => truongHoc;
            //set => truongHoc = value;
        }

        //Phần 4: Các phương thức của đối tượng
        public void InRaManHinh()
        {
            Console.WriteLine($"{ten} | {msv} | {(gt==1?"Nam":"Nữ")} | {ns} | {truongHoc}");
        }

        //Trong lập trình có 1 khái niệm gọi là TÁI SỬ DỤNG
    }
}
