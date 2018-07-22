using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ResponsibilityChain
{
    /// <summary>
    /// 技术经理
    /// </summary>
    public class TM:Node
    {
        public TM(string name)
        {
            Console.WriteLine("准备TM {0}审批环节", name);
        }

        //public Context Audit(Context applyContext)
        //{
        //    if (applyContext.Hour <= 24)
        //    {
        //        applyContext.AuditState = 2;
        //        applyContext.AuditRemark = "技术经理通过申请";
        //    }
        //    else
        //        applyContext.AuditState = 1;
        //    return applyContext;
        //}

        public override Context Audit(Context applyContext)
        {
            if (applyContext.Hour <= 24)
            {
                applyContext.AuditState = 2;
                applyContext.AuditRemark = "技术经理通过申请";
            }
            else
            {
                if (base.NextNode == null)//没有下一个节点
                {
                    applyContext.AuditState = 3;
                    applyContext.AuditRemark = "技术经理审批未通过";
                }
                else
                {
                    applyContext.AuditState = 1;
                    base.NextNode.Audit(applyContext);
                }
            }
            return applyContext;
        }
    }
}
