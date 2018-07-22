using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 外观模式，门面模式，屏蔽了子系统的复杂度，上端没有改，降低了客户端和子系统的耦合，然后把耦合移到了中间层
/// 迪米特法则：客户端--中间层--子系统，客户端不知道子系统，比如三层结构
/// UI--BLL--DAL--(Model) UI层并不知道DAL层发生的事
/// 外观模式就是一种封装，把客户端和子系统通过外观类解触耦合，三层模式就是最好的体现
/// </summary>
namespace _10Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            int userId = 11;
            int cityId = 188;
            int commodityId = 5726;
            /*01*/
            //User user = new User();
            //if (!user.Check(userId))
            //{
            //    return;
            //}

            //Order order = new Order();
            //if (!order.Check(commodityId))
            //{
            //    return;
            //}

            //Logistical logistical = new Logistical();
            //if (!logistical.Check(cityId))
            //{
            //    return;
            //}
            /*以上 上端下端都耦合得很紧密*/
            /*以下 就是外观模式。让门面好看简洁，并把所有的都用一个类封装起来*/
            /*上层并不知道下端做了多少事 */
            FacadeCenter facadeCenter = new FacadeCenter();
            if (!facadeCenter.CheckUserOrder(userId, commodityId, cityId))
            {
                Console.WriteLine("检测未通过，不能购买");
                return;//表示方法结束  不能购买
            }

            Console.WriteLine("可以购买，do it");
            Console.Read();
        }
    }
}
