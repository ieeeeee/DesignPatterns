using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Visitor
{
    public class VisitorNow:IVisitor
    {
        public void GetVideoFree()
        {
            Console.WriteLine("免费学员可以获取当次课程的视频");
        }

        public void GetVideoVip()
        {
            Console.WriteLine("vip学员可以获取全部课程的视频课件和代码");
        }
    }
}
