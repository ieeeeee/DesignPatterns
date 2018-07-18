using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01MySingleton
{
   public  class SingletonThird
    {
        private long LResult = 0;
        private SingletonThird()
        {
            for (int i = 0; i < 1000000000; i++) //int32的范围20忆左右
            {
                LResult += i;
            }
            Console.WriteLine("在这里被初始化了，LResult={0},ThreadId={1}", LResult, Thread.CurrentThread.ManagedThreadId);
        }
        private static SingletonThird _SingletonThird = new SingletonThird();
        public static SingletonThird CreateInstance()
        {
            return _SingletonThird;
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
