using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AbstractFactory
{
    /// <summary>
    /// 冰封王座
    /// </summary>
    public class FrozenThroneFactory:BaseFactory
    {
        #region
        //public Human CreateHuman()
        //{
        //    return new Human();
        //}
        //public NE CreateNE()
        //{
        //    return new NE();
        //}

        //public Orc CreateOrc()
        //{
        //    return new Orc()
        //}
        //public Undead CreateUndead()
        //{
        //    return new Undead();
        //}
        #endregion



        /* 继承抽象类，要实现抽象方法  */
        public override IRace CreateFirst()
        {
            return new Human();
        }
        public override IRace CreateSecond()
        {
            return new NE();
        }
        public override IRace CreateThird()
        {
            return new Orc();
        }
        public override IRace CreateForth()
        {
            return new Undead();
        }
    }
}
