using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_CRUD_OOP_LIST
{
    internal class Kem
    {
        private string ten;
        private string ma;
        private string huongVi;
        private int loaiKem;//1 - Kem ốc quế | 2 - Kem que

        public Kem()
        {

        }

        public Kem(string ten, string ma, string huongVi, int loaiKem)
        {
            this.ten = ten;
            this.ma = ma;
            this.huongVi = huongVi;
            this.loaiKem = loaiKem;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Ma
        {
            get => ma;
            set => ma = value;
        }

        public string HuongVi
        {
            get => huongVi;
            set => huongVi = value;
        }

        public int LoaiKem
        {
            get => loaiKem;
            set => loaiKem = value;
        }

        public void InBingChilling()
        {
            Console.WriteLine($"BingChilling: {Ten} - {Ma} - {HuongVi} - {(loaiKem ==1 ?"Ốc quế":"Kem Que")}");
        }
    }
}
