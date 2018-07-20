using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Bridge
{
    /// <summary>
    /// 基础抽象类
    /// </summary>
    public abstract class BasePhone 
    {
        //public abstract string System();
        public abstract void Call();
        public abstract void Message();

        /*03*/
        public ISystem CurrentSystem = null;
    }
}
