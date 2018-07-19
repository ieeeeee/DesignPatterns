using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04AbstractFactory
{
    /// <summary>
    /// 人族  暗夜  兽族  不死
    /// 魏    蜀    吴    群
    /// </summary>
    public abstract class BaseFactory
    {
        /* 抽象方法必须在抽象类中 */
        public abstract IRace CreateFirst();
        public abstract IRace CreateSecond();
        public abstract IRace CreateThird();
        public abstract IRace CreateForth();

     
    }
}
