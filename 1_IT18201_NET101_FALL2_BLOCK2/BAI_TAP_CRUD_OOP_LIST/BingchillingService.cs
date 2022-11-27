using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_CRUD_OOP_LIST
{
    //Các chức năng sẽ được code tại đây
    internal class BingchillingService
    {
        //Toàn bộ biến toàn cục bắt buộc phải khai báo trên đầu
        private string _input;
        private List<Kem> _lstKems;
        private Kem _kem;
        public BingchillingService()
        {
            _lstKems = new List<Kem>()
            {
                new Kem(){Ten = "Kem 1",Ma = "K1",HuongVi = "Học loại",LoaiKem = 1},
                new Kem(){Ten = "Kem 2",Ma = "K2",HuongVi = "Mát lạnh",LoaiKem = 1},
                new Kem(){Ten = "Kem 3",Ma = "K2",HuongVi = "Siêu cay",LoaiKem = 2},
            };//Gán giá trị Fake vào cho List
            _kem = new Kem();
        }

        public void ThemKem()
        {
            Console.Write("Mời bạn nhập số lượng: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _kem = new Kem();
                Console.Write("Mời bạn nhập tên: ");
                _kem.Ten = Console.ReadLine();
                Console.Write("Mời bạn nhập Mã: ");
                _kem.Ma = Console.ReadLine();
                Console.Write("Mời bạn nhập Hương Vị: ");
                _kem.HuongVi = Console.ReadLine();
                Console.Write("Mời bạn nhập loại kem: ");
                _kem.LoaiKem = Convert.ToInt32(Console.ReadLine());
                _lstKems.Add(_kem);
            }

            Console.WriteLine("Thêm thành công.");
        }
        public void SuaKem()
        {

        }
        public void XoaKem()
        {

        }
        public void InDsKem()
        {
            foreach (var x in _lstKems)
            {
               x.InBingChilling();
            }
        }
    }
}
