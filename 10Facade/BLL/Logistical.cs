using _10Facade.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10Facade
{
    /// <summary>
    /// 物流,继承接口，就是对现有的类进行抽象
    /// </summary>
    public class Logistical:ILogistical
    {
        public bool Check(int cityId)
        {
            Console.WriteLine("当前城市物流是可达的");
            return true;
        }
    }
}
