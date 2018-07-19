using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05PropertyModel
{
    [Serializable]
   public  class StudentProperty
    {
        private StudentProperty()
        {
            long lRsult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lRsult += i;
            }
            Console.WriteLine("构造函数计算完成 {0}", lRsult);
        }
        private static StudentProperty _StudentProperty = null;
        static  StudentProperty()
        {
            _StudentProperty = new StudentProperty();
            _StudentProperty.Name = "构造1";
            _StudentProperty.Class = new Advanced()
            {
                Id = 1,
                Name = "班级1班"
            };
        }
        public static StudentProperty CreateInstanceClone()
        {
            //原型模式，创建一个对象，并把它复制出来,可以快速的创造一大堆对象
            StudentProperty studentCopy = (StudentProperty)_StudentProperty.MemberwiseClone();
            return studentCopy;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Now { get; set; }
        public Advanced Class { get; set; }
    }

    [Serializable]
    public class Advanced
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
