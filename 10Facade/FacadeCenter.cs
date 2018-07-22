using _10Facade.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Facade
{
    /// <summary>
    /// 外观中心
    /// </summary>
   public class FacadeCenter
    {
        public bool CheckUserOrder(int userId, int commodityId, int cityId)
        {
            //User user = new User();
            //Order order = new Order();
            //Logistical logistical = new Logistical();
            //return user.Check(userId) && order.Check(commodityId) && logistical.Check(cityId);
            IUser user = new User();//简单工厂+反射
            IOrder order = new Order();
            ILogistical logistical = new Logistical();
            //用接口，是将外观类和细节类更加的解耦
            return user.Check(userId) && order.Check(commodityId) && logistical.Check(cityId);
        }
    }
}
