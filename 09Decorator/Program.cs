using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Decorator
{
    /// <summary>
    /// 装饰器模式,想对原有的类增加功能时，又不想增加类，就可以用装饰器，很灵活，还可以额外添加装备，类似于AOP
    /// 缺点：会导致很多装饰器的子类,对象多
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //CharactorBase mage = new Mage();
            //mage.Show();

            //CharactorBase mageWithHead = new MageWithHead();
            //mageWithHead.Show();

            CharactorBase mage = new Mage();//造一个法师
            mage.Show();

            Console.WriteLine("*******************************************");
            mage = new CharactorDecoratorHead(mage);
            mage.Show();

            Console.WriteLine("*******************************************");
            mage = new CharactorDecoratorShoulder(mage);
            mage.Show();


            Console.WriteLine("*******************************************");
            mage = new CharactorDecoratorCuirass(mage);
            mage = new CharactorDecoratorTrousers(mage);
            mage.Show();



            Console.Read();
        }
    }
}
