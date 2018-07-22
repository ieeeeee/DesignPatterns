using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Proxy
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class ObjectClassProxy:IObjectClass
    {
        private static ObjectClass objectClass = new ObjectClass();

        private static object objectClassProxy_Lock = new object();
        /// <summary>
        /// 创造函数，只创建一个对象
        /// </summary>
        public ObjectClassProxy()
        {
            if(objectClass == null)//初始化之后不再进入lock
            {
                lock(objectClassProxy_Lock)
                {
                    if (objectClass == null)
                    {
                        objectClass = new ObjectClass();
                    }
                }

            }
        }
        /// <summary>
        /// 获取点东西
        /// </summary>
        public void GetSomething()
        {
            try//异常代理   日志代理   邮件代理   事务代理   缓存代理  有效性代理  性能监控   记数代理
            {
                objectClass.GetSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine("出现异常，{0}", ex.Message);
            }
        }

        /// <summary>
        /// 做点儿事
        /// </summary>
        public void DoSomething()
        {
            try
            {

                objectClass.DoSomething();
            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常，{0}", ex.Message);
            }
        }

    }
}
