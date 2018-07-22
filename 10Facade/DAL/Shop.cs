using _10Facade.InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Facade.DAL
{
    /// <summary>
    /// 店铺
    /// </summary>
   public  class Shop:IShop
    {
        public int GetShopId(int commodityId)
        {
            return 3;
        }

        public bool CheckState(int shopId)
        {
            return shopId == 3;
        }
    }
}
