using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_KeThua
{
    internal class F1:F0
    {
        private string thuocTinh3;
        private string thuocTinh4;

        public F1()
        {

        }


        public F1(string thuocTinh1, string thuocTinh2, string thuocTinh3, string thuocTinh4) : base(thuocTinh1, thuocTinh2)
        {
            this.thuocTinh3 = thuocTinh3;
            this.thuocTinh4 = thuocTinh4;
        }
    }
}
