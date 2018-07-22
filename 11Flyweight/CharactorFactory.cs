using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Flyweight
{
    public class CharactorFactory
    {
        //创建一个静态的字典
        private static Dictionary<string, AbstractCharactor> CharactorDictionary = new Dictionary<string, AbstractCharactor>();

        private static object CharactorLock = new object();
        public static AbstractCharactor CreateCharactor(CharactorEnum charactorEnum)
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
                                CharactorDictionary.Add(CharactorEnum.E.ToString(), new E());
                            }
                        }
                    }
                    return CharactorDictionary[CharactorEnum.E.ToString()];


                //case CharactorEnum.E:
                //    if (CharactorDictionary.ContainsKey(CharactorEnum.E.ToString()))
                //    {
                //        return CharactorDictionary[CharactorEnum.E.ToString()];
                //    }
                //    else
                //    {
                //        E e = new E();
                //        CharactorDictionary.Add(CharactorEnum.E.ToString(), e);
                //        return e;
                //    }//02 如果没有，我们就放进字典，如果有，我们直接从字典取，不再创建
                //这就是享元模式，把元控制起来，公用一个对象，不是由对象本身来控制创建（单例），而是通过工厂
                //多线程可能有问题

                //case CharactorEnum.E:
                //    return new E();  //01
                case CharactorEnum.L:
                    return new L();
                case CharactorEnum.N:
                    return new N();
                case CharactorEnum.V:
                    return new V();
                default:
                    throw new Exception("wrong CharactorEnum");
            }
        }
    }
    public enum CharactorEnum
    {
        E,
        L,
        V,
        N
    }
}
