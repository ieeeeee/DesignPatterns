using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Observer
{
    /// <summary>
    /// 观察者模式,
    /// .net的委托事件，就是观察者模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Baby baby = new Baby();
            baby.Cry();



            Console.WriteLine("*************new Cry******************");
            baby.AddObserver(new Father());
            baby.AddObserver(new Mother());
            baby.AddObserver(new Dog());
            baby.AddObserver(new Cat());
            baby.AddObserver(new Mouse());

            baby.AddObserver(new Neighboor());
            /* IObserver 抽象的观察者
              father其他的观察者，baby 是个主题,abstractSubject 是对baby的抽象 */

            baby.NewCry();


            /* 注册事件 在事件时，不需要统一，注册的是方法，基于委托 ，之前的都是注册的都是对象
             winform的按钮事件都是基于观察者模式
            */
            Console.WriteLine("*************Cry event******************");
            baby.BabyCryHandler += new Father().Roar;
            baby.BabyCryHandler += new Mother().Whisper;
            baby.BabyCryHandler += new Dog().Bark;
            baby.BabyCryHandler += new Cat().Run;
            baby.BabyCryHandler += new Mouse().Hide;
            baby.BabyCryHandler += new Neighboor().Awake;

            baby.CryEvent();


            Action<string, int, DateTime> action = new Action<string, int, DateTime>(Test);
            action("测试", 11, DateTime.Now);
            Console.ReadKey();
        }

        private static void Test(string name, int id, DateTime now)
        {
            Console.WriteLine("{0}{1}{2}", name, id, now);
        }
    }
}
