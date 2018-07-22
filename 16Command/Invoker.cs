using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Command
{
    /// <summary>
    /// 调用命令的人，对命令的管理
    /// 实际上invoker还可以识别command，自行定义reveiver
    /// </summary>
    public class Invoker
    {
        private BaseCommand Command = null;
        public Invoker(BaseCommand command)
        {
            Command = command;
            //解析command  根据其他信息  创建reveiver  并指定
            BaseReceiver reveiver = new WriteReceiver();
            Command.SetReceiver(reveiver);
        }
        public void Execute(Document doc)
        {
            Command.Execute(doc);
        }
    }
}
