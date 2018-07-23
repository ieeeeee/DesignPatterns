using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Stratege
{
    /// <summary>
    /// 加法
    /// </summary>
    public class PlusStrategy:BaseStrategy
    {
        public override int Calculation()
        {
            return LeftInput + RightInput;
        }
    }

}
