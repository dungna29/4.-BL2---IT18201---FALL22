using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_6_Switch_Case
{
    internal class Program
    { /*
         * Switch Case câu lệnh rẽ nhành và thường được sử dụng làm menu trong lập trình.
         *
         * Công thức: sw + tab
         *
         *  switch (<Biểu thức>)
            {
                case <giá trị 1>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                case <giá trị 2>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                .......
                case <giá trị n>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                default:
                    Khi không thỏa mãn tất cả các trường hợp trên thì sẽ vào default
                    break;
            }
         */

        static void Main(string[] args)
        {
            string input;
            do
            {

                Console.WriteLine("Menu");
                Console.WriteLine("1. Phở bò");
                Console.WriteLine("2. Cơm rang");
                Console.WriteLine("3. Cơm trắng");
                Console.WriteLine("4. Thoát");
                Console.Write("Mời bạn chọn món: ");
                input = Console.ReadLine();//Hứng giá trị người dùng nhập vào
                switch (input)
                {
                    case "1":
                        //Thực hiện 1 hành động nào đó
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        break;
                }
            } while (!(input == "4"));
        }
    }
}
