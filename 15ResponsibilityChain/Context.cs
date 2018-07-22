using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ResponsibilityChain
{
    /// <summary>
    /// 上下文，一般是环境
    /// </summary>
    public class Context
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hour { get; set; }
        /// <summary>
        /// 0 未审核  1审核中 2审核通过  3审核不通过
        /// </summary>
        public int AuditState { get; set; }
        public string AuditRemark { get; set; }
    }
}
