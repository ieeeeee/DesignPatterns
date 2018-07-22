using _10Facade.DAL;
using _10Facade.Interface;
using _10Facade.InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10Facade
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Order:IOrder
    {
      
        public bool Check(int commodityId)
        {
            //做了很多操作
            ICommodity iCommodity = new Commodity();

            int iResult = iCommodity.GetCount(commodityId);
            if (iResult < 1) return false;
            IShop iShop = new Shop();
            if (!iShop.CheckState(iShop.GetShopId(commodityId))) return false;

            Console.WriteLine("当前商品是可以购买的");
            return true;
        }
    }
}
