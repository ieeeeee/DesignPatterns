using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05PropertyModel
{
    public class Student
    {
        //单例创建对象
        //构造函数，私有化，其他类就调用不了，只有通过方法调用
        private Student()
        {
            long lRsult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lRsult += i;
            }
            Console.WriteLine("构造函数计算完成 {0}", lRsult);
        }

        private static Student _Student = null;
        static Student()
        {
            _Student = new Student();
        }
        public static Student CreateInstanceSingleton()
        {
            return _Student;
        }
        public string Name { get; set; }
    }
}
