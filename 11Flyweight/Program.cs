using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _11Flyweight.CharactorFactory;

namespace _11Flyweight
{
    /// <summary>
    /// 享元模式
    /// 单例永远只有一个对象，在对象上控制
    /// 享元模式也可以用于数据库连接，在数据连接池，可以提供10个连接，在工厂上控制对象的创建
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //打印老师的名字 eleven
            //E e1 = new E();
            //L l = new L();
            //E e2 = new E();
            //V v = new V();
            //E e3 = new E();
            //N n = new N();
            //Console.WriteLine("{0}{1}{2}{3}{4}{5}", e1.GetWord(), l.GetWord(), e2.GetWord(), v.GetWord(), e3.GetWord(), n.GetWord());
            /*把所有的类抽象下*/
            /*我们不可能把所有的e 都分别创建一个对象，我们只需要将e创建一个对象就可以展示出结果，这就是享元*/
            /* 会被实例化太多次，内存会受不了*/
            /* 关键是把元抽出来 */

            string teacher = "Eleven";
            string man = "Eleven";
            Console.WriteLine(teacher == man);//值
            Console.WriteLine(teacher.Equals(man));//值
            Console.WriteLine(Object.ReferenceEquals(teacher, man));//比较的是引用   string字符串的内存分配使用了享元模式

            StringBuilder sb = new StringBuilder();
            sb.Append("El");
            sb.Append("ev");
            sb.Append("en");

            string newMan = sb.ToString();

            Console.WriteLine(teacher == newMan);//值
            Console.WriteLine(teacher.Equals(newMan));//值
            Console.WriteLine(Object.ReferenceEquals(teacher, newMan));//比较的是引用 

            AbstractCharactor e1 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e2 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e3 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e4 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e5 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e6 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e7 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor l = CharactorFactory.CreateCharactor(CharactorEnum.L);
            AbstractCharactor v = CharactorFactory.CreateCharactor(CharactorEnum.V);
            AbstractCharactor n = CharactorFactory.CreateCharactor(CharactorEnum.N);
            Console.WriteLine("{0}{1}{2}{3}{4}{5}", e1.GetWord(), l.GetWord(), e2.GetWord(), v.GetWord(), e3.GetWord(), n.GetWord());


            Console.ReadKey();
       }
   }
}
