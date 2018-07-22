using _10Facade.InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Facade.DAL
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Commodity:ICommodity
    {
        public int GetCount(int commodityId)
        {
            return 100;
        }
    }
}
