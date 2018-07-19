using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AbstractFactory
{
    /// <summary>
    /// 三国杀
    /// </summary>
    public class SanGuoShaFactory:BaseFactory
    {
        #region
        //public Qun CreateQun()
        //{
        //    return new Qun();
        //}
        //public Wu CreateWu()
        //{
        //    return new Wu();
        //}
        //public Shu CreateShu()
        //{
        //    return new Shu();
        //}
        //public Wei CreateWei()
        //{
        //    return new Wei();
        //}
        #endregion


        public override IRace CreateFirst()
        {
            return new S_Wei();
        }

        public override IRace CreateSecond()
        {
            return new S_Shu();
        }

        public override IRace CreateThird()
        {
            return new S_Wu();
        }

        public override IRace CreateForth()
        {
            return new S_Qun();
        }
    }
}
