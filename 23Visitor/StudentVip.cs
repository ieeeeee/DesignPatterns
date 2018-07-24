using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Visitor
{
    public class StudentVip:Student
    {
        public override void GetVideo(IVisitor visitor)
        {
            visitor.GetVideoVip();
        }
    }
}
