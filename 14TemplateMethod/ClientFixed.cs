using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14TemplateMethod
{
    /// <summary>
    /// 定期存款，利息率
    /// </summary>
   public  class ClientFixed:ClientBase
    {

        /// <summary>
        /// 计算利息
        /// </summary>
        /// <returns></returns>
        public override double GetInterest()
        {
            return 10240000 * 0.0002;
        }

        public override void Show(string account, double amount, double interest)
        {
            Console.WriteLine("这里是定期存款");
            base.Show(account, amount, interest);
        }
    }
}
