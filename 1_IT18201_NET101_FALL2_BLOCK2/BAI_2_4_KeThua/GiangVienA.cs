using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_KeThua
{
    internal class GiangVienA
    {
        private string id;
        private string namSinh;
        private string ten;
        private string diaChi;
        private string sdt;
        private string mgv;
        private string nganhDay;
        private string chucVu;

        public GiangVienA()
        {

        }

        public GiangVienA(string id, string namSinh, string ten, string diaChi, string sdt, string mgv, string nganhDay, string chucVu)
        {
            this.id = id;
            this.namSinh = namSinh;
            this.ten = ten;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.mgv = mgv;
            this.nganhDay = nganhDay;
            this.chucVu = chucVu;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string Mgv
        {
            get => mgv;
            set => mgv = value;
        }

        public string NganhDay
        {
            get => nganhDay;
            set => nganhDay = value;
        }

        public string ChucVu
        {
            get => chucVu;
            set => chucVu = value;
        }
    }
}
