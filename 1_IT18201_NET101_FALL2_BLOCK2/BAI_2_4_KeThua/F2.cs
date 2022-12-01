using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_KeThua
{
    internal class F2:F1
    {
        private string thuocTinh5;
        private string thuocTinh6;

        public F2(string thuocTinh1, string thuocTinh2, string thuocTinh3, string thuocTinh4, string thuocTinh5, string thuocTinh6) : base(thuocTinh1, thuocTinh2, thuocTinh3, thuocTinh4)
        {
            this.thuocTinh5 = thuocTinh5;
            this.thuocTinh6 = thuocTinh6;
        }
    }
}
