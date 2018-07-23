using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21State
{
    public class YellowLight:AbstractLight
    {
        public YellowLight()
         : base(LightState.Yellow)
        {
        }

        /// <summary>
        /// 状态模式，只知道下一个动作
        /// </summary>
        /// <param name="context"></param>
        public override void Change(Context context)
        {
            Console.WriteLine("当前的颜色是 {0},change一下", this.State.ToString());
            //Change 黄1 =》红
            context.Set(new RedLight());

        }
    }
}
