using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Visitor
{
    public class VisitorBefore:IVisitor
    {
        public void GetVideoFree()
        {
            Console.WriteLine("免费学员没有视频，只能在线观看"); ;
        }

        public void GetVideoVip()
        {
            Console.WriteLine("拥有全部vip视频，公开课没有视频");
        }
    }
}
