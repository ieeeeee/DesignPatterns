using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace _02SimpleFactory
{
    /// <summary>
    /// 工厂类，负责对象的创建
    /// </summary>
   public class Factory
    {
        public static IRace CreateInstance(RaceType raceType)
        {
            switch(raceType)
            {
                case RaceType.Human:
                    return new Human();
                case RaceType.Orc:
                    return new Orc();
                case RaceType.NE:
                    return new NE();
                case RaceType.Undead:
                    return new Undead();
                default:
                    throw new Exception("wrong raceType");
                
            }
        }


        private static string RaceTypeConfig = ConfigurationManager.AppSettings["RaceTypeConfig"];
        public static IRace CreateInstanceConfig()
        {
            switch ((RaceType)Enum.Parse(typeof(RaceType),RaceTypeConfig))
            {
                case RaceType.Human:
                    return new Human();
                case RaceType.Orc:
                    return new Orc();
                case RaceType.NE:
                    return new NE();
                case RaceType.Undead:
                    return new Undead();
                default:
                    throw new Exception("wrong raceType");

            }
        }

        /// <summary>
        /// 通过反射，需要什么对象，自动去创建什么对象
        /// </summary>
        private static string RaceTypeReflect = ConfigurationManager.AppSettings["RaceTypeReflect"];
        public static IRace CreateInstanceReflect()
        {
            string assembleName = RaceTypeReflect.Split(',')[0];
            string typeName = RaceTypeReflect.Split(',')[1];
            return (IRace)(Activator.CreateInstance(assembleName, typeName).Unwrap());
        }


        public enum RaceType
        {
            Human,
            Orc,
            NE,
            Undead
        }
    }
}
