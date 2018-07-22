using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Observer
{
    public class Cat
    {
        public void Run()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "Run");
        }

        public void Notify()
        {
            this.Run();
        }
    }
}
