using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21State
{
    /// <summary>
    /// 上下文,上端就操作这个上下文
    /// </summary>
    public class Context
    {
        private AbstractLight Light = null;
        public Context(AbstractLight light)
        {
            this.Light = light;//this 当前的实例
        }

        /// <summary>
        /// 每次change就是把context的灯换掉
        /// </summary>
        public void Change()
        {
            this.Light.Change(this);
        }
        public void Set(AbstractLight light)
        {
            this.Light = light;
        }
    }
}
