using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_KeThua
{
    internal class SinhVienA
    {
        private string id;
        private string namSinh;
        private string ten;
        private string diaChi;
        private string sdt;
        private string msv;
        private string nganhHoc;

        public SinhVienA()
        {

        }

        public SinhVienA(string id, string namSinh, string ten, string diaChi, string sdt, string msv, string nganhHoc)
        {
            this.id = id;
            this.namSinh = namSinh;
            this.ten = ten;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.msv = msv;
            this.nganhHoc = nganhHoc;
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
    }
}
