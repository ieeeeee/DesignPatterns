using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Command
{
    /// <summary>
    /// 命令，和接收对应
    /// </summary>
    public abstract class BaseCommand
    {
        /// <summary>
        /// 指定处理人
        /// </summary>
        /// <param name="receiver"></param>
        public abstract void SetReceiver(BaseReceiver receiver);

        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="doc"></param>
        public abstract void Execute(Document doc);
    }
}
