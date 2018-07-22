using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14TemplateMethod
{
    public abstract class ClientBase
    {
        /// <summary>
        /// 把每一步都拆成一个方法，为了单一职责，方便维护\
        /// 模板方法
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        public void ShowInfo(string account,string password)
        {
            if(CheckAccount(account,password))
            {
                if(!IsSecret(account))
                {
                    double amount = GetAmount();//查询余额
                    double interest = GetInterest();//计算利息
                    Show(account, amount, interest);//展示数据
                }
                else
                {
                    Console.WriteLine("这里是保密账户，不允许查询");
                }

            }
        }

        public bool CheckAccount(string account,string password)
        {
            return account.Equals("Adam") && password.Equals("9527");
        }
        public double GetAmount()
        {
            return 10240000;
        }
        public abstract double GetInterest();

        public virtual bool IsSecret(string account)
        {
            return false;
        }

        public virtual void Show(string account,double amount,double interest)
        {
            Console.WriteLine("{0}  拥有{1}￥,利息为{2}", account, amount, interest);
        }
    }
}
