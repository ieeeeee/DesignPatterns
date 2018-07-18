using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FactoryMethod
{
    public class Undead:IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The king of Undead is Gostop");
        }
    }
}
