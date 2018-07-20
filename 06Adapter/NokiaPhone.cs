using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Adapter
{
    class NokiaPhone:IPhone
    {
        public void Call()
        {
            Console.WriteLine("这里是{0}的Call", this.GetType());
        }
    }
}
