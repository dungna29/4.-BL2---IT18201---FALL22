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
                Console.WriteLine("Mời bạn nhập loại kem: ");
                Console.Write("1. Kem ốc quế ");
                Console.Write("2. Kem que");
                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        _kem.LoaiKem = 1;
                        break;
                    case "2":
                        _kem.LoaiKem = 2;
                        break;
                    default:
                        Console.WriteLine("Loại kem bạn chọn không có. Chúng sẽ để mặc định là Kem ốc quế");
                        _kem.LoaiKem = 1;
                        break;
                }
                _lstKems.Add(_kem);//Sau khi nhập thông tin cho 1 đối tượng kem thì sẽ add đối tượng vào trong List.
            }

            Console.WriteLine("Thêm thành công.");
        }
        public void ThemKem1()
        {

            _input = GetValueInput("số lượng");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _lstKems.Add(new Kem(GetValueInput("tên"),GetValueInput("mã"),GetValueInput("hương vị"),Convert.ToInt32(GetValueInput("loại"))));
            }

            Console.WriteLine("Thêm thành công.");
        }
        public void SuaKem()
        {
            Console.Write("Mời bạn nhập mã: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstKems.Count; i++)
            {
                if (_lstKems[i].Ma.ToLower() == _input.ToLower())
                {
                    // Làm đúng phải sử dụng switchCase để chọn thuộc tính cần sửa.
                    Console.WriteLine("Mời bạn nhập tên mới: ");
                    _lstKems[i].Ten = Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("Không tìm thấy");
        }
        public void XoaKem()
        {
            int temp = GetIndexByMa();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            _lstKems.RemoveAt(temp);


        }
        public void TimKiemKem()//Tìm kiếm tuyệt đối
        {
            Console.Write("Mời bạn nhập mã: ");
            _input = Console.ReadLine();
            _lstKems.Where(c=>c.Ma == _input).FirstOrDefault().InBingChilling();
            //for (int i = 0; i < _lstKems.Count; i++)
            //{
            //    if (_lstKems[i].Ma.ToLower() == _input.ToLower())
            //    {
            //        _lstKems[i].InBingChilling();
            //        return;
            //    }
            //}

            //Console.WriteLine("Không tìm thấy");
        }
        public void InDsKem()
        {
            foreach (var x in _lstKems)
            {
                x.InBingChilling();
            }
        }
        public void Sort()
        {
            _lstKems = _lstKems.OrderByDescending(c => c.LoaiKem).ToList();//Linq
            _lstKems.Sort((x,y)=>x.Ma.CompareTo(y.Ma));//Sử dụng thư viện có sẵn.
        }

        //Áp dụng phương thức trả về.
        private string GetValueInput(string msg)
        {
            Console.Write($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }

        private int GetIndexByMa()
        {
            string ma = GetValueInput("mã");
            //Dùng for:
            //for (int i = 0; i < _lstKems.Count; i++)
            //{
            //    if (_lstKems[i].Ma == ma)
            //    {
            //        return i;
            //    }
            //}
            //Không dùng for
            return _lstKems.FindIndex(c => c.Ma == ma);
            //return -1;
        }
    }
}
