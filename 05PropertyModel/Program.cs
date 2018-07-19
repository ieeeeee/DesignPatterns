using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 原型模式
/// </summary>
namespace _05PropertyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = Student.CreateInstanceSingleton();
            //student1.Name = "学生1";

            //Student student2 = Student.CreateInstanceSingleton();
            //student2.Name = "学生2";
            /* 上部分的执行结果 student1 的name 会被覆盖，变成学生2*/


            //StudentProperty studentProperty1 = StudentProperty.CreateInstanceClone();
            //Console.WriteLine("{0}", studentProperty1.Name);
            //studentProperty1.Name = "复制1";

            //StudentProperty studentProperty2 = StudentProperty.CreateInstanceClone();
            //Console.WriteLine("{0}", studentProperty2.Name);
            //studentProperty2.Name = "复制2";

            //Console.WriteLine("{0}",studentProperty1.Name);

            //Console.WriteLine("{0}", studentProperty2.Name);
            /*  以上部分浅克隆 ，不会出现问题 */


            StudentProperty studentProperty1 = StudentProperty.CreateInstanceClone();
            studentProperty1.Name = "复制1"; //string 也是引用类型 =的赋值，就是把studentProperty1重新指定了一个引用，
            studentProperty1.Id = 1;
            studentProperty1.Now = DateTime.Now;
            Console.WriteLine("s11{0}", studentProperty1.Class.Name);
            studentProperty1.Class.Name = "重定义班级1班";
            Console.WriteLine("s12{0}，{1}", studentProperty1.Name, studentProperty1.Class.Name);


            StudentProperty studentProperty2 = StudentProperty.CreateInstanceClone();
            //这两个对象引用同一个地址，其中的引用对象class 是引用的同一个地址
            studentProperty2.Name = "复制2";
            studentProperty2.Id = 2;
            studentProperty2.Now = DateTime.Now.AddDays(1);
            Console.WriteLine("s21{0}", studentProperty2.Class.Name);//而class 这儿是重新指定了一个地址，但两个对象还是指向这同一个class
            //student1=>指向class  class=>addr1=>addr2
            //student2=>class 
            
            studentProperty2.Class.Name = "班级2班";
            Console.WriteLine("s13{0}，{1}", studentProperty1.Name,studentProperty1.Class.Name);

            Console.WriteLine("s22{0}，{1}", studentProperty2.Name,studentProperty2.Class.Name);
            /* 以上部分浅克隆，当引用了class 时 s1 和 s2 的class.name 都是s2的*/


            //借助序列化，实现深克隆
            //StudentProperty类要标记 [Serializable]特性后，才允许序列化，其中的Advanced 也要[Serializable]
            StudentProperty studentProperty3 = SerializeHelper.Derializable<StudentProperty>(SerializeHelper.Serializable(studentProperty2));
            studentProperty3.Class.Name = "深度克隆3班";



            Console.WriteLine("s31{0}", studentProperty3.Class.Name);

            Console.Read();

        }
    }
}
