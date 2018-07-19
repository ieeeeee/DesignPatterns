using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 抽象工厂，扩展的是工厂，一个产品的扩展，比如数据访问层，如果是用MSSQL，需要用mysql了,抽象工厂还可以再扩展一个mysql的数据访问模块
/// 比如数据库只有增删改查这四种方法 
/// 在工厂上的一个扩展
/// </summary>
namespace _04AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂，创建实例的方法有很多职责，违背了单一原则
            //于是我们拆成了工厂方法，每个类一个工厂
            //拆成每个方法

            //FrozenThroneFactory factory = new FrozenThroneFactory();
            //IRace human = factory.CreateHuman();
            //human.ShowKing();


            //只有一个工厂的职责是稳定的时候才使用
            //缺陷：如果增加第五类，每个继承的工厂都要进行重构变化
            BaseFactory frozenFactory = new FrozenThroneFactory();
            IRace human = frozenFactory.CreateFirst();
            human.ShowKing();

            BaseFactory sanguoshaFactory = new SanGuoShaFactory();
            IRace qun = sanguoshaFactory.CreateForth();
            qun.ShowKing();
            Console.Read();

        }
    }
}
