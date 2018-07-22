using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ResponsibilityChain
{
    public class CEO:Node
    {
        public CEO(string name)
        {
            Console.WriteLine("准备TM {0}审批环节", name);
        }

        public override Context Audit(Context applyContext)
        {
            if (applyContext.Hour <= 80)
            {
                applyContext.AuditState = 2;
                applyContext.AuditRemark = "CEO通过申请";
            }
            else
            {
                if (base.NextNode == null)//没有下一个节点
                {
                    applyContext.AuditState = 3;
                    applyContext.AuditRemark = "CEO审批未通过";
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
