using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Iterator
{
    /// <summary>
    /// 数据容器
    /// </summary>
    public class DataContainer
    {
        /// <summary>
        /// 私有的，不是公开的，就不是list自己的遍历
        /// </summary>
        private  List<int> IntList = new List<int>()
        {
             1,2,3,4,6,7,89,123,32,324,23,43,43,5,354,4
        };
    
       /* 以下就是迭代器，提供了遍历访问，迭代器就是外面的调用并不知道内部做了什么，可以被调用实现遍历*/
          
        private int Index = 0;
        public int Get()
        {
            return IntList[Index++];
        }
        public bool IsEnd()
        {
            return Index >= IntList.Count();
        }
    }
}
