using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14TemplateMethod
{
    /// <summary>
    /// 活期存款
    /// </summary>
   public  class ClientCurrent:ClientBase
    {
        /// <summary>
        /// 计算利息
        /// </summary>
        /// <returns></returns>
        public override double GetInterest()
        {
            return 10240000 * 0.0001;
        }

        public override void Show(string account, double amount, double interest)
        {
            Console.WriteLine("这里是活期存款");
            base.Show(account, amount, interest);
        }

    }


}
