using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01MySingleton
{
   public  class Singleton
    {

        private static bool IsInit = false;
        private static object Singleton_Lock = new object();
        private long LResult = 0;
        private Singleton()
        {
            for (int i = 0; i < 1000000000; i++) //int32的范围20忆左右
            {
                LResult += i;
            }
            Console.WriteLine("在这里被初始化了，LResult={0},ThreadId={1}", LResult, Thread.CurrentThread.ManagedThreadId);
        }

        private static Singleton _Singleton = null; //私有化，不给外面实例化，就只会有一个
        public static Singleton CreateInstance()
        {
            if (_Singleton == null)
            {
                //lock 最好是静态的 object类型的，任何时候只保有一个线程去判断，
                //多线程的东西进来的时候，就会去判断这个对象别人在用没有
                lock (Singleton_Lock)
                {
                    if (_Singleton == null)
                    {
                        _Singleton = new Singleton();
                    }
                }
            }
            return _Singleton;
        }

        public int Id { get; set; }

        public void SayHi()
        {
            Console.WriteLine("早上好");
        }

        public long GetResult()
        {
            return LResult;
        }
    }
}
