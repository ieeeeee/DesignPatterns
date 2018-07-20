using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Bridge
{
   public class Sumsong:BasePhone
    {
        /*01、02*/
        //public override string System()
        //{
        //    return "Android";
        //}
        //public override void Call()
        //{
        //    Console.WriteLine("使用{0}打电话", this.GetType());
        //}

        //public override void Message()
        //{
        //    Console.WriteLine("使用{0}发短信", this.GetType());
        //}

        /*03*/
        public override void Call()
        {
            Console.WriteLine("使用{0} {1}打电话", this.GetType(), CurrentSystem.System());
        }

        public override void Message()
        {
            Console.WriteLine("使用{0} {1}发短信", this.GetType(), CurrentSystem.System());
        }
    }
}
