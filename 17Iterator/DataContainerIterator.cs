using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Iterator
{
    /// <summary>
    /// 想遍历这这些元素
    /// </summary>
   public class DataContainerIterator : WhileIterator<int>
    {
        public DataContainerIterator()
            :base(IntListNow)
        {

        }
        private static List<int> IntListNow = new List<int>()
        {
            1,2,3,4,6,7,89,123,32,324,23,43,43,5,354,4
        };
    }
}
