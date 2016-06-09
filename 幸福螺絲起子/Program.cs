using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 幸福螺絲起子配件;

namespace 幸福螺絲起子
{
    class Program
    {
        static void Main(string[] args)
        {
            不是OOP幸福螺絲起子("小一字");
            OOP幸福螺絲起子("大十字");
        }

        private static void 不是OOP幸福螺絲起子(string 大小形狀)
        {
            string 工具頭 = string.Empty;
            switch (大小形狀)
            {
                case "大十字":
                    工具頭 = "大十字";
                    break;
                case "大一字":
                    工具頭 = "大一字";
                    break;
                case "小一字":
                    工具頭 = "小一字";
                    break;
                default:
                    throw new SystemException(@"沒有此規格");
            }
            Console.WriteLine("工具頭是" + 工具頭);
            Console.WriteLine("幸福螺絲起子啟動 完畢 ");
            Console.ReadLine();
        }

        private static void OOP幸福螺絲起子(string 大小形狀)
        {
            幸福螺絲起子換頭介面 工具頭 = 工具頭袋子.取出工具頭(大小形狀);

            Console.WriteLine("工具頭是" + 工具頭.組合工具頭());
            Console.WriteLine("幸福螺絲起子啟動 完畢 ");
            Console.ReadLine();
        }
    }
}
