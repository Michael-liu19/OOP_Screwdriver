using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 幸福螺絲起子配件
{
    public class 大十字 : 幸福螺絲起子換頭介面
    {
        public string 工具頭 { get; set; }
        public 大十字()
        {
            工具頭 = "大十字";
        }

        public string 組合工具頭()
        {
            return 工具頭;
        }

    }
}
