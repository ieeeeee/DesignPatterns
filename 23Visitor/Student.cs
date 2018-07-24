using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Visitor
{
    public class Student
    {
        public int QQ { get; set; }
        public string Name { get; set; }
        public virtual void GetVideo(IVisitor visitor)
        {

        }
    }
}
