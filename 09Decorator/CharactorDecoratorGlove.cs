using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Decorator
{
    public class CharactorDecoratorGlove:CharactorDecoratorBase
    {
        public CharactorDecoratorGlove(CharactorBase charactor)
            :base(charactor)
        {

        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("带上凌风手套");
        }
    }
}
