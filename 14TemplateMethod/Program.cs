using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14TemplateMethod
{
    /// <summary>
    /// 模板方法设计模式,有一套固定的流程
    /// 钩子方法,
    /// 桥接模式对比
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /* 模板方法，有一套固定的规则流程 */
            /*其他的存款方式，利息不一样，总额也不一样*/
            /* 我们在上端调用模板方法，起到代码的重用，也方便进行扩展，有一个父类，有多个子类*/
            /*通用方法，就放在clientbase父类中*/
            ClientBase clientCurrent = new ClientCurrent();
            clientCurrent.ShowInfo("Adam", "9527");

            ClientBase clientFixed = new ClientFixed();
            clientFixed.ShowInfo("Adam", "9527");

            /*当我们流程不一样时，不如出现保密账户，不允许查询,我们就需要把查询方法virtual*/
            /*父类的查询方法，issecret为钩子方法，需要子类控制住父类的流程.子类可以影响到父类的行为，就叫钩子方法*/
            /*virtual 其子类没有重写这个方法就不会替换子类的方法，也可不重写*/
            /*此处钩子方法：违背了里氏替换原则*/

            /*模板方法 解决不了子类爆炸的情况*/
            ClientBase clientSecret = new ClientSecret();
            clientSecret.ShowInfo("Adam", "9527");
            Console.Read();
        }
    }
}
