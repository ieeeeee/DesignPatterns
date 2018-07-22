using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Decorator
{
    /// <summary>
    /// 装饰器的基类,装饰器我们都要继承CharactorBase
    /// </summary>
    public class CharactorDecoratorBase :CharactorBase
    {
        //对谁进行装饰
        protected CharactorBase Charactor;
        public CharactorDecoratorBase(CharactorBase charactor)
        {
            this.Charactor = charactor;
        }

        public override void Show()
        {
            this.Charactor.Show();
            Console.WriteLine("给角色动态的换装备");
        }
    }
}
