using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new StudentVip()
                                {
                                    Name = "vip1",
                                    QQ = 11111111
                                });
            studentList.Add(new StudentVip()
            {
                Name = "vip2",
                QQ = 2222222
            });
            studentList.Add(new StudentFree()
            {
                Name = "free1",
                QQ = 00000011
            });
            studentList.Add(new StudentFree()
            {
                Name = "free2",
                QQ = 00000022
            });
            foreach (Student student in studentList)
            {
                Console.WriteLine("QQ={0} Name={1}", student.QQ, student.Name);
                if (student is StudentFree)
                {
                    Console.WriteLine("免费学员可以获取当次课程的视频");
                }
                else if (student is StudentVip)
                {
                    Console.WriteLine("vip学员可以获取全部课程的视频课件和代码");
                }
            }
                Console.WriteLine("****************VisitorBefore********************");

            /*不同类型，方式不同；同一类型 方式也不同；访问的方法可能是不同的*/
            Console.Read();
        }
    }
}
