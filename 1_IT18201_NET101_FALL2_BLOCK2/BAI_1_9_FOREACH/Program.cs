using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_9_FOREACH
{
    internal class Program
    {
        /*
       * Vòng lặp foreach
       * Cách gõ: fore + tab
       *
       * Công thức:
       *  foreach (var VARIABLE in COLLECTION)
          {
          }
          var: Kiểu dữ liệu đã học ở bài khai báo biến
          VARIABLE: tên biến có thể đặt tùy ý và nó đại diện cho kiểu dữ liệu.
          COLLECTION//Array: Phải là 1 tập hợp nhiều giá trị.
       */
        static void Main(string[] args)
        {
            int[] arrNumbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int x in arrNumbers)
            {
                if (x%2!=0)
                {
                    continue;
                }
                Console.Write(x + " ");
            }
            //Chỉ in số chẵn
        }
    }
}
