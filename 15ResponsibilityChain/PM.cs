using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ResponsibilityChain
{
    /// <summary>
    /// 项目经理，如果时间小于8，通过
    /// </summary>
    public class PM:Node
    {
        public PM(string name)
        {
            Console.WriteLine("准备PM {0}审批环节", name);
        }
        //public Context Audit(Context applyContext)
        //{
        //    if (applyContext.Hour <= 8)
        //    {
        //        applyContext.AuditState = 2;
        //        applyContext.AuditRemark = "项目经理通过申请";
        //    }
        //    else//否则应该交给下一个  TM
        //        applyContext.AuditState = 1;
        //    return applyContext;
        //}

        public override Context Audit(Context applyContext)
        {
            if (applyContext.Hour <= 8)
            {
                applyContext.AuditState = 2;
                applyContext.AuditRemark = "项目经理通过申请";
            }
            else
            {
                if (base.NextNode == null)//没有下一个节点
                {
                    applyContext.AuditState = 3;
                    applyContext.AuditRemark = "项目经理审批未通过";
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
