using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ResponsibilityChain
{
    /// <summary>
    /// 责任链
    /// 管道处理模型，就是一个责任链，Web开发对请求的处理httpmodule httphandler
    /// httpContext 请求的上下文，有的module处理cookie,session,权限，filter也是责任链模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //Context requestContext = new Context()
            //{
            //    Id = 1,
            //    Name = "Matt",
            //    Description = "因为欧冠决赛，请假一天",
            //    Hour = 16,
            //    AuditState = 0,
            //    AuditRemark = ""
            //};
            //PM pm = new PM("黄");
            //TM tm = new TM("张");
            //pm.Audit(requestContext);

            //if (requestContext.AuditState == 2)
            //{
            //    Console.WriteLine("{0} 审批通过，可以看欧冠了，马德里德比", requestContext.AuditRemark);
            //}
            //else if (requestContext.AuditState == 1)
            //{
            //    tm.Audit(requestContext);

            //    if (requestContext.AuditState == 2)
            //    {
            //        Console.WriteLine("{0} 审批通过，可以看欧冠了，马德里德比", requestContext.AuditRemark);
            //    }
            //    else
            //    {
            //        Console.WriteLine("审批未通过，小气的PM");
            //    }
            //}

            /*多个人的审批就是责任链，这个事情应该由责任链自行传递，不应该由申请人去推动*/
            {
                while (true)
                {
                    Console.WriteLine("************************************");
                    Console.WriteLine("请输入你要申请的小时数");
                    string hour = Console.ReadLine();
                    Context requestContext = new Context()
                    {
                        Id = 1,
                        Name = "Matt",
                        Description = "因为欧冠决赛，请假一天",
                        Hour = int.Parse(hour),
                        AuditState = 0,
                        AuditRemark = ""
                    };
                    PM pm = new PM("黄");
                    TM tm = new TM("张");
                    TD td = new TD("梦");
                    CEO ceo = new CEO("天天");

                    pm.NextNode = tm;
                    tm.NextNode = td;
                    td.NextNode = ceo;


                    pm.Audit(requestContext);
                    if (requestContext.AuditState == 2)
                    {
                        Console.WriteLine("{0} 审批通过，可以看欧冠了，马德里德比", requestContext.AuditRemark);
                    }
                    else
                    {
                        Console.WriteLine("{0} 审批未通过，小气的领导", requestContext.AuditRemark);
                    }

                }
            }



            Console.Read();
        }
    }
}
