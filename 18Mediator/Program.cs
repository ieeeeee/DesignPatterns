using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Mediator
{
    /// <summary>
    /// 中介者模式,解决消息的不对称
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SomebodyA somebodyA = new SomebodyA("A");
            SomebodyB somebodyB = new SomebodyB("B");
            somebodyA.SendMessage("解决消息不对称", somebodyB);
            /*以上，就只有AB两个对象，当有复杂的多个对象，多种关系时,我们就通过第三个*/
            /* 有点像简单工厂，外观模式*/
            /*用户表，菜单表，这种多对多的关系，有个中间表，就是中介
             不关心这个用户有多少个菜单，也不关心菜单会有多少个用户，两者的关系都是通过中介表来体现的*/
            Console.WriteLine("*******************************");
            Student studentA = new Student("Nc");
            Student studentB = new Student("Nd");
            Student studentC = new Student("Ne");
            Student studentD = new Student("Nf");
            Student studentE = new Student("Ng");
            Student studentF = new Student("Nh");
            Student studentG = new Student("Ni");
            Student studentH = new Student("Nj");

            ChatMediator mediator1 = new ChatMediator(new List<Student>() { studentA, studentB });
            studentA.SendMessage("我今天很开心", mediator1);
            studentB.SendMessage("我今天也很开心", mediator1);
            studentA.SendMessage("这是为什么呢", mediator1);
            studentB.SendMessage("因为我学到了中介者模式，你是为什么呢", mediator1);
            studentA.SendMessage("我是因为上榜了", mediator1);
            studentB.SendMessage("我也上榜了", mediator1);

            ChatMediator mediator2 = new ChatMediator(new List<Student>() { studentA, studentC });

            studentA.SendMessage("我今天很开心", mediator2);
            studentC.SendMessage("我今天也很开心", mediator2);


            Console.WriteLine("**************群聊**************");

            ChatMediator mediator3 = new ChatMediator(new List<Student>() { studentA, studentB, studentC, studentD, studentE, studentF, studentG, studentH });

            studentF.SendMessage("欢迎大家加入高级班", mediator3);
            Console.Read();
        }
    }
}
