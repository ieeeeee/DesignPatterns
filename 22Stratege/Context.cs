using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Stratege
{
    /// <summary>
    /// 策略环境
    /// </summary>
   public class Context
    {
        //获取当前操作系统  还可能是很多其他的数据，是计算所需要的，而客户端无需关心的
        private static string OperateSystem = "Win10";

        private BaseStrategy Strategy = null;
        public Context(BaseStrategy strategy)
        {
            Strategy = strategy;
        }

        public int Calculation(int leftInput,int rightInput)
        {
            try
            {
                Console.WriteLine("这里是{0}的计算", Context.OperateSystem);
                this.Strategy.LeftInput = leftInput;
                this.Strategy.RightInput = rightInput;
                return this.Strategy.Calculation();
            }
            catch (Exception ex)
            {
                //log
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
