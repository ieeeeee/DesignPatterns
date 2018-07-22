using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Observer
{
    public class Baby
    {
        public void Cry()
        {
            Console.WriteLine("{0}{1}", this.GetType(), "Cry");
            new Father().Roar();
            new Mother().Whisper();
            new Mouse().Hide();
            new Cat().Run();

            new Dog().Bark();
        }
    }
}
