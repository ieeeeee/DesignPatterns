using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 工厂方法
/// </summary>
namespace _03FactoryMethod
{
    /// <summary>
    /// 上端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //HumanFactory humanFanctory = new HumanFactory();
            //IRace human = humanFanctory.CreateInstance();
           // human.ShowKing();
            //抽象是稳定的
            //解决了简单模式中，下端和工厂的高度耦合,任何一个类变化都要去修改工厂，严重违反了单一职责，工厂类就变得不稳定
            //humanFactory==IFactoryMethod
            //human==IRace
            //工厂方法就是把简单工厂类的东西拆开，一个对象造一个工厂用来创建对象，也可以进行扩展
            //开闭原则：对扩展开放，对修改封闭
            //要求我们的上端不出现Human 这种细节,才是面向抽象的，才是可扩展的
            //缺陷：会让代码使用起来很麻烦
            IFactoryMethod humanFanctory = new HumanFactory();
            IRace human = humanFanctory.CreateInstance();
            human.ShowKing();

            Console.Read();
            //如果第五种族，只需要增加新的类，新的类的工厂，只要是增加，就是对扩展开放
        }
    }
}
