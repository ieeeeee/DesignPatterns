using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Decorator
{
    public class CharactorDecoratorHead:CharactorDecoratorBase
    {
        public CharactorDecoratorHead(CharactorBase charactor)
            :base(charactor)//base 此处是调用此类的父类的构造方法
        {

        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("带上凌风头盔");
        }
    }
}
