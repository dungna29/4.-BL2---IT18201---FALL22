using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_ArrayList
{
    internal class Program
    {
        /*
           *  ArrayList
           *  Định nghĩa: Là một Collections giúp lưu trữ và quản lý một
                          danh sách các đối tượng theo kiểu mảng (truy
                          cập các phần tử bên trong thông qua chỉ số
                          index)
              Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                          linh hoạt và có thể tự điều chỉnh kích cỡ một
                          cách tự động.
              Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                          thêm thư viện System.Collections
              Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
           */

        /*
          * A. CÁC PHƯƠNG THỨC TRONG ArrayList
          * 1. Add(object Value): Thêm đối tượng vào cuối.
          * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
          * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
          * 4. Clear(): Xóa tất cả các phần tử.
          * 5. Clone(): Tạo 1 bản sao của danh sách đó.
          * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
          * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
          * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
          */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Khai báo 1 ArrayList không định kiểu
            ArrayList arrLstNumbers;//khai báo
            arrLstNumbers = new ArrayList();//Khởi tạo 1 ArrayListk

            //Phần 2:Gán giá trị thông qua phương thức add()
            arrLstNumbers.Add(1);
            arrLstNumbers.Add(true);
            arrLstNumbers.Add("123");
            arrLstNumbers.Add('1');
            arrLstNumbers.Add(9.2);

            //Phần 3: Lấy giá trị thông qua index
            Console.WriteLine(arrLstNumbers[3]);// '1'

            //arrLstNumbers.Count = độ dài của ArrayList
            for (int i = 0; i < arrLstNumbers.Count; i++)
            {
                Console.WriteLine(arrLstNumbers[i]);
            }

            //Ngoài ra sử dụng 1 vài phương thức có sẵn.
            arrLstNumbers.RemoveAt(1);
            arrLstNumbers.Clear();//Xóa hết

            arrLstNumbers = new ArrayList();//Khi khởi tạo lại thì toàn bộ các phần tử bên trong sẽ bị Clear
            arrLstNumbers.Sort();

        }
    }
}
