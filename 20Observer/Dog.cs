using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Observer
{
    public class Dog : IObserver
    {
        public void Bark()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "Bark");
        }
        public void Notify()
        {
            this.Bark();
        }
    }
}
