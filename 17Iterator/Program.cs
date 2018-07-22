using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Iterator
{
    /// <summary>
    /// 迭代器模式
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            List<int> intList = new List<int>()
            {
                1,2,3,4,6,7,89,123,32,324,23,43,43,5,354,4
            };

            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }
            /*进行遍历*/

            Console.WriteLine("********************************************");
            DataContainer dataContainer = new DataContainer();
            while(!dataContainer.IsEnd())
            {
                Console.WriteLine(dataContainer.Get());
            }
            /* 以上就是自己实现了遍历 */

            Console.WriteLine("*********************DataContainerIterator***********************");

            IIterator<int> iterator = new DataContainerIterator();

            while (!iterator.IsEnd())
            {
                Console.WriteLine(iterator.Get());
            }

            Console.WriteLine("*********************Collection***********************");

            Console.WriteLine("当前时间{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            Collection collection = new Collection();
            //collection.GetEnumerator();
            foreach (int i in collection)
            {
                Console.WriteLine("{0}   {1}", DateTime.Now.ToString("yyyyMMddHHmmss"), i);
            }
            //foreach  实现一定要一个公开的IEnumerator方法
            //迭代 一般继承一个IEnumerable接口，实现一个GetEnumerator()方法

            Console.Read();
            //反射可以破坏私有化
        }
    }
}
