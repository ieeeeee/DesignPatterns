using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Stratege
{
    /// <summary>
    /// 简单工厂，只负责创建对象
    /// </summary>
    public class SimpleFactory
    {
        public static BaseStrategy CreateInstance(string sOperate)
        {
            BaseStrategy strategy = null;
            switch (sOperate)//基于配置文件和反射继续升级
            {
                case "+":
                    {
                        strategy = new PlusStrategy();
                    }
                    break;
                case "-":
                    {
                        strategy = new MinusStrategy();
                    }
                    break;
                case "*":
                    {
                        strategy = new MutiplyStrategy();
                    }
                    break;
                case "/":
                    {
                        strategy = new DivisionStrategy();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("操作符号异常");
                        throw new Exception("操作符号异常");
                    }
            }
            return strategy;
        }
    }
}
