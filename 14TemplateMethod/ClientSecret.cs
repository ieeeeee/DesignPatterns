using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14TemplateMethod
{
    class ClientSecret:ClientBase
    {
        /// <summary>
        /// 计算利息
        /// </summary>
        /// <returns></returns>
        public override double GetInterest()
        {
            return 10240000 * 0.0002;
        }

        public override bool IsSecret(string account)
        {
            return true;
        }
    }
}
