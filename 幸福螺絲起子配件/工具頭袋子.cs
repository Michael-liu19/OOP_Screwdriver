using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 幸福螺絲起子配件
{
    public static class 工具頭袋子
    {
        private static readonly List<幸福螺絲起子換頭介面> _工具頭列表;

        static 工具頭袋子()
        {
            _工具頭列表 = new List<幸福螺絲起子換頭介面>();
            _工具頭列表.Add(new 大十字());
            _工具頭列表.Add(new 大一字());
            _工具頭列表.Add(new 小一字());
        }

        public static 幸福螺絲起子換頭介面 取出工具頭(string 大小形狀)
        {
            return _工具頭列表.First(x => x.工具頭.Equals(大小形狀) );
        }
    }
    

}
