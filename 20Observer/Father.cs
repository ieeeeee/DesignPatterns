using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Observer
{
    public class Father
    {
        public void Roar()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "Roar");
        }
        public void Notify()
        {
            this.Roar();
        }
    }
}
