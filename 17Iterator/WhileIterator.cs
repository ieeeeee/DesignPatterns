using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Iterator
{
    /// <summary>
    /// 迭代器
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WhileIterator<T>:IIterator<T>
    {
        private List<T> IntList;
        public WhileIterator(List<T> intList)
        {
            IntList = intList;
        }

        private int Index = 0;
        public T Get()
        {
            return IntList[Index++];
        }
        public bool IsEnd()
        {
            return Index >= IntList.Count();
        }
    }
}
