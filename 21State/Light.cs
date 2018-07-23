using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21State
{
    /// <summary>
    /// 交通灯
    /// </summary>
    public  class Light
    {
        public LightState State
        {
            get;
            private set;
        }

        public Light(LightState state)
        {
            this.State = state;
        }
        public void SetGreen()
        {
            this.State = LightState.Green;
        }

        public void SetRed()
        {
            this.State = LightState.Red;
        }

        public void SetYellow()
        {
            this.State = LightState.Yellow;
        }

        public void Change()
        {
            Console.WriteLine("当前的颜色是 {0},change一下", this.State.ToString());

            if (this.State == LightState.Green)
            {
                this.SetYellow();
            }
            else if (this.State == LightState.Yellow)
            {
                this.SetRed();
            }
            else if (this.State == LightState.Red)
            {
                this.SetGreen();
            }
        }

    }
    public enum LightState
    {
        Red = 0,
        Green = 1,
        Yellow = 2,
        Yellow2 = 3
    }
}
