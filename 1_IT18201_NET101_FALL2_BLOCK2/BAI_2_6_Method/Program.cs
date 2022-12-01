using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_Method
{
    internal class Program
    {
        /*
      *  Bài 2.9 Phương thức - Method
      *  Định nghĩa: 1 tập các câu lệnh cùng nhau thực hiện 1 tác vụ nào đó.
      *  LỢI ÍCH: - Giúp quản lý code tốt hơn
      *           - Tái sử dụng
      *
      *  Công thức chung:
      *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
      *  {
      *          Body code
      *  }
        *
      * <Phạm vi truy cập> - Access Specifier:Public,Private,Protected, Default, Internal
      *
      * <Kiểu trả về> : có 2 kiểu trả về và không trả về
      *          - Kiểu không trả về: void
      *          - Kiểu trả về: là giá trị đơn(int,string,double....) hoặc tập giá trị(Array,List.....) hoặc đối tượng(class) và còn nhiều kiểu khác.
      *
      * <Tên phương thức>: Tên động từ viết thường + tên.
      * <Danh sách tham số>: Phương thức có thể có tham hoặc không tham số và lưu ý khi sử dụng tham số thì khi gọi phương thức thì phải truyền đúng vị trí của tham số và kiểu dữ liệu.
       PHƯƠNG THỨC KHÔNG ĐƯỢC TRÙNG TÊN NHƯNG ĐƯỢC PHÉP TRÙNG TÊN VÀ KHÁC THAM SỐ
      */

        static void Main(string[] args)
        {
            #region Phương thức void

            MethodVoid mv = new MethodVoid();
            //Phần 1: Muốn gọi 1 phương thức thì phải biến tên và nơi đặt phương thức đó.
            mv.TinhTong2So();//Gọi đến phương thức cần sử dụng kết thúc có dấu ();

            //Phương thức có tham số cần lưu ý
            /*
            * 1. Truyền tham số đúng theo vị trí
            * 2. Đúng kiểu dữ liệu
            * 3. Truyền đủ tham số đầu vào không được thiếu.
            * 4. Đối với phương thức nạp chồng thì số lượng tham số và kiểu dữ liệu sẽ quyết định gọi đến phương thức nào
            */
            mv.TinhTong();
            mv.TinhTong(1,1);
            mv.TinhTong(1,1,1);
            mv.TinhTong(1,1,"1");
            #endregion

            #region Phương thức trả về:

            MethodTraVe mtv = new MethodTraVe();
            int a = 5;
            int b = a + 5;
            int c = mtv.TinhTong(1,1) + 5;

            for (int i = 0; i < mtv.GetNs1800().Count; i++)
            {
                Console.WriteLine(mtv.GetNs1800()[i]);
            }

            #endregion
        }
    }
}
