using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 简单工厂，对对象做了一个抽象，将创建对象放进了一个工厂去创建
/// </summary>
namespace _02SimpleFactory
{
    /// <summary>
    /// 上端展示类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //上端直接调用Human，是一一调用，叫紧密耦合,面向细节的
            Human human = new Human();
            human.ShowKing();

            Orc orc = new Orc();
            orc.ShowKing();


            //我们实际上要面向抽象，就是用接口或者抽象类
            // IRace human1 = new Human(); 还是细节的

            //建一个工厂来负责对象的创建
            //好处：在上端是稳定的，上端和下端是通过接口依赖的，不用处理细节，不用创建对象
            //缺点：耦合移到了工厂，增加时还是要修改工厂，工厂还是高度耦合的，矛盾转移了，严重违背了设计模式的单一职责
            //上端还是指定了参数
            IRace human2 = Factory.CreateInstance(Factory.RaceType.Human);
            human2.ShowKing();

          

            IRace undead = Factory.CreateInstance(Factory.RaceType.Undead);
            undead.ShowKing();


            //简单工厂的进阶+配置文件 实现程序的可配置
            Console.WriteLine("*********************CreateInstanceConfig**********************");
            IRace iRace = Factory.CreateInstanceConfig();
            iRace.ShowKing();

            //简单工厂的进阶+反射,实现程序的可配置，可扩展  在上端和工厂里都没有细节，可扩展的如果加一个新的类，把新的项目生成的dll放进此项目，就可以用了
            Console.WriteLine("*********************CreateInstanceReflect**********************");
            IRace iRace2 = Factory.CreateInstanceReflect();
            iRace2.ShowKing();

            Console.Read();
        }
    }
}
