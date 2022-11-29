using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_KeThua
{
    //Lớp người ta sẽ coi nó là lớp cha và nó như lớp đối tượng bình thường.
    internal class Nguoi
    {
        //Đưa các thuộc tính chung và phương thức chung lên lớp.
        private string id;
        private string namSinh;
        private string ten;
        private string diaChi;
        private string sdt;

        public Nguoi()
        {

        }

        public Nguoi(string id, string namSinh, string ten, string diaChi, string sdt)
        {
            this.id = id;
            this.namSinh = namSinh;
            this.ten = ten;
            this.diaChi = diaChi;
            this.sdt = sdt;
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

        //Các phương thức của cha
        public virtual void InRaManHinh()
        {
            Console.WriteLine("Đây là phương thức của cha");
        }
        public virtual void Method1()
        {

        }
        private void Method2()
        {

        }
    }
}
