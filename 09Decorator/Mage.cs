using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Decorator
{
    /// <summary>
    /// 法师
    /// </summary>
    public class Mage:CharactorBase
    {
        public override void Show()
        {
            Console.WriteLine("这里是法师 ieee");
        }
    }

    //五件套 头  胸甲  肩膀  手套  裤子

        /// <summary>
        /// 使用集成的时候，是在编译器就确定了功能，如果有很多套装就要写很多个类，代码就又会爆炸
        /// </summary>
    public class MageWithHead : Mage
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("带上凌风头");
        }
    }
}
