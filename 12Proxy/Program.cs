using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Proxy
{
    /// <summary>
    /// 代理模式，是结构模式,代理类多了一步，多了一层，比如加事务，都可以在代理类去扩展
    /// 代理是为了加控制，webservice,异常代理，日志代理，事务，右键，缓存，有效性，性能，计数，ORM
    /// 上端和真实使用的类之间，加了个中间层，中间层就可以做很多事，但不能增加类的行为
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    ObjectClass objectClass = new ObjectClass();
            //    objectClass.GetSomething();
            //    objectClass.DoSomething();
            //}

            //catch (Exception ex)
            //{

            //    Console.WriteLine("出现异常，{0}", ex.Message);
            //}

            /*抽象工厂是建造模式*/

            //当如果想加个异常处理时，可以在代理类进行try catch
            //IObjectClass objectClassProxy = new ObjectClassProxy();
            //objectClassProxy.GetSomething();
            //objectClassProxy.DoSomething();



            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();
            }

            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();

            }

            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();
            }


            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();
            }

            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();
            }

            Console.Read();
        }
    }
}
