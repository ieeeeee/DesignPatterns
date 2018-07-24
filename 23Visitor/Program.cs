using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Visitor
{
    /// <summary>
    /// 拜访者模式
    /// </summary>
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
            //foreach (Student student in studentList)
            //{
            //    Console.WriteLine("QQ={0} Name={1}", student.QQ, student.Name);
            //    if (student is StudentFree)
            //    {
            //        Console.WriteLine("免费学员可以获取当次课程的视频");
            //    }
            //    else if (student is StudentVip)
            //    {
            //        Console.WriteLine("vip学员可以获取全部课程的视频课件和代码");
            //    }

                //if (student is StudentFree && before)
                //{
                //    VisitorBefore.GetVideoFree(); 1
                //}
                //else if (student is StudentFree && now)
                //{
                //    VisitorNow.GetVideoFree(); 2
                //}
                //else if (student is StudentVip && before)
                //{
                //    VisitorBefore.GetVideoVip(); 3
                //}
                //else if (student is StudentVip && now)
                //{
                //    VisitorNow.GetVideoVip(); 4
                //}
            //}
            Console.WriteLine("****************VisitorBefore********************");
            foreach(Student student in studentList)
            {
                Console.WriteLine("QQ={0} Name={1}", student.QQ, student.Name);
                student.GetVideo(new VisitorBefore());
            }
            Console.WriteLine("****************VisitorNow********************");
            foreach (Student student in studentList)
            {
                Console.WriteLine("QQ={0} Name={1}", student.QQ, student.Name);
                student.GetVideo(new VisitorNow());
            }

            /*不同类型，方式不同；同一类型 方式也不同；访问的方法可能是不同的
             对不同的成员，对不同的处理方式，对这种判断一大推的条件，就可以用visitor模式，变化的封装
             student不能扩展，但visitor可以扩展
             M*N 这种，也可以用组合模式*/

            Console.Read();
        }
    }
}
