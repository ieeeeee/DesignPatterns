using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21State
{
    /// <summary>
    /// 状态模式,一个对象随着每次调用，就会修改自身的状态，并展示不同的行为
    /// 节点进行自我管理，更适合流程环节确定的
    /// 队列处理任务
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light(LightState.Green);
            //绿  黄   红  绿  黄   红 
            light.Change();
            light.Change();
            light.Change();
            light.Change();
            light.Change();
            light.Change();
            /*light  这种代码简单的情况下，更方便于统观全局*/

            //把变换的职责交给context
            //把职责拆分了，但是类变多了
            //绿 黄1 红 黄2 绿 黄1
            Console.WriteLine("*************Context******************");
            Context context = new Context(new GreenLight());//最开始准备一个绿灯
            context.Change();
            context.Change();
            context.Change();
            context.Change();
            context.Change();
            context.Change();
            Console.Read();
        }
    }
}
