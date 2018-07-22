using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Flyweight
{
    public class Connection
    {
        public int Id { get; set; }
        public int State { get; set; }
    }
    /// <summary>
    /// 连接池，思想上就是享元的
    /// </summary>
    public class ConnectionPool
    {
        private static Dictionary<string, List<Connection>> CharactorDictionary = new Dictionary<string, List<Connection>>();
        private static object CharactorLock = new object();

        public static void CreateCharactor(CharactorEnum charactorEnum)
        {
            switch (charactorEnum)
            {
                case CharactorEnum.E:
                    if (!CharactorDictionary.ContainsKey(CharactorEnum.E.ToString()))//保证在对象被初始化后，不再进入锁
                    {
                        lock (CharactorLock)//控制多线程的进入
                        {
                            if (!CharactorDictionary.ContainsKey(CharactorEnum.E.ToString()))//单个线程判断是否存在
                            {
                                //Init Pool
                            }
                        }
                    }
                    //return  pool.GetFree and Count 闲置够不够？  不够就new一个  多了 就释放
                    break;



                default:
                    throw new Exception("wrong CharactorEnum");
            }
        }
    }
}
