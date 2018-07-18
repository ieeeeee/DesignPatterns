using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01MySingleton
{
    /// <summary>
    /// 单例模式，在整个进程只会被实例化一次,控制一个类只被外面调用的实例化一次,如何使用单例模式，如一个对象去写日志
    /// 保证内存中只有一个对象，避免对象的重复创建，比如数据库连接池，因为连接池只会占用资源
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("欢迎学习单例模式");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            /*单线程*/
            //for(int i=0;i<10;i++)
            //{
            //    Singleton singleton = new Singleton();//实例化
            //    singleton.SayHi();
            //    Console.WriteLine("最终需要的是{0}", singleton.GetResult());
            //}
            List<Task> taskList = new List<Task>();
            TaskFactory taskFactory = new TaskFactory();
            for (int i = 0; i < 10; i++)
            {
                /*启用多线程 都随机的进入，占用CPU资源.*/
                taskList.Add(taskFactory.StartNew(() =>
                {
                    //Singleton singleton = new Singleton();//写到这里的话，就会启用很多对象，在构造函数时候私有化，类给一个方法出来
                    SingletonSecond singleton = SingletonSecond.CreateInstance();
                    singleton.SayHi();
                    Console.WriteLine("最终需要的是{0}，ThreadId={1}", singleton.GetResult(), Thread.CurrentThread.ManagedThreadId);
                }));
            }
            Task.WaitAll(taskList.ToArray());
            stopwatch.Stop();
            Console.WriteLine("一共耗时{0}毫秒", stopwatch.ElapsedMilliseconds);
            for (int i = 0; i < 10; i++)
            {
                /*启用多线程 都随机的进入，占用CPU资源.*/
                taskList.Add(taskFactory.StartNew(() =>
                {
                    //Singleton singleton = new Singleton();//写到这里的话，就会启用很多对象，在构造函数时候私有化，类给一个方法出来
                    SingletonSecond singleton = SingletonSecond.CreateInstance();
                    singleton.SayHi();
                    Console.WriteLine("最终需要的是{0}，ThreadId={1}", singleton.GetResult(), Thread.CurrentThread.ManagedThreadId);
                }));
            }
            Console.ReadKey();
        }
    }
}
