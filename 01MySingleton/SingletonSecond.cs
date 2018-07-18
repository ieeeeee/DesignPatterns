using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01MySingleton
{
   public class SingletonSecond
    {
        private long LResult = 0;
        private SingletonSecond()
        {
            for (int i = 0; i < 1000000000; i++) //int32的范围20忆左右
            {
                LResult += i;
            }
            Console.WriteLine("在这里被初始化了，LResult={0},ThreadId={1}", LResult, Thread.CurrentThread.ManagedThreadId);
        }
        static SingletonSecond()//CLR运行时候 第一次使用这个类之前，一定会而且只会执行一次
        {
            _SingletonSecond = new SingletonSecond();
        }
        //保证只能实例化一次，私有化，在内部使用
        //就提供一个方法出去，让外面调用
        private static SingletonSecond _SingletonSecond = null;
        public static SingletonSecond CreateInstance()
        {
            return _SingletonSecond;
        }


        public int Id { get; set; }

        public void SayHi()
        {
            Console.WriteLine("早上好，如何正确的瞎吐槽丶");
        }

        public long GetResult()
        {
            return LResult;
        }
    }
}
