using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ResponsibilityChain
{
    /// <summary>
    /// 节点
    /// </summary>
    public abstract class Node
    {
        /// <summary>
        /// 下一个处理人
        /// </summary>
        public Node NextNode { get; set; }

        /// <summary>
        /// 审批动作
        /// </summary>
        /// <param name="applyContext"></param>
        /// <returns></returns>
        public abstract Context Audit(Context applyContext);
    }
}
