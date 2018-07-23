using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Stratege
{
    public class DivisionStrategy:BaseStrategy
    {
        /// <summary>
        /// 由override 去实现这个就是多态
        /// </summary>
        /// <returns></returns>
        public override int Calculation()
        {
           if(base.RightInput==0)
            {
                Console.WriteLine("除数不能为0，计算失败");
                //return 0;//应该终止计算
                throw new Exception("除数不能为0，计算失败");
            }
            return LeftInput / RightInput;
        }
    }
}
