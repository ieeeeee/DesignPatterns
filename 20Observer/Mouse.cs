using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Observer
{
   public  class Mouse : IObserver
    {
        public void Hide()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "Hide");
        }
        public void Notify()
        {
            this.Hide();
        }
    }
}
