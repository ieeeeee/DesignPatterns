using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Command
{
    /// <summary>
    /// 命令模式
    /// 行为：类与行为
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document()
            {
                Id = 11,
                Name = "高级班vip课程介绍",
                Content = ".net高级班6月初开学，火热报名中",
                CreateTime = DateTime.Now
            };

            //doc.Read();
            //doc.Write();
            /* 以上 对象和行为是耦合的 命令模式，就是把对象和行为解耦*/

            BaseReceiver reveiver = new ReadReceiver();
            reveiver.Execute(doc);
            /*以上 把对象和行为分离，每个行为每个类 */

            /*调用方和接收方都是分离的 把变化封装到command中去了*/
            /*比如数据库操作，数据库更新操作，还要写日志，然后可以把日志同步给其他数据库*/
            /* 读写分离也是命令模式*/

            BaseCommand command = new ReadCommand();
            //command.SetReceiver(reveiver);//指定处理人
            //command.Execute(doc);

            Invoker invoker = new Invoker(command);
            invoker.Execute(doc);

            /*委托 是基于方法签名，可以动态注册多个执行方法，命令模式是基于类级别的*/

            Console.Read();
        }

    }
}
