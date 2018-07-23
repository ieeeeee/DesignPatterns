using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Observer
{
    public class Baby
    {
        public void Cry()
        {
            Console.WriteLine("{0}{1}", this.GetType(), "Cry");
            new Father().Roar();
            new Mother().Whisper();
            new Mouse().Hide();
            new Cat().Run();

            new Dog().Bark();
        }

        /*观察者模式 就是把上面的细节都耦合了*/
        private List<IObserver> ObserverList = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            ObserverList.Add(observer);
        }

        public void NewCry()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "NewCry");
            if(ObserverList!=null&&ObserverList.Count()>0)
            {
                foreach(IObserver observer in ObserverList)
                {
                    //observer.Notify();
                    new Action(observer.Notify).BeginInvoke(null, null);//异步
                }
            }
        }

        //action 就是一个委托,无返回值，有返回值是func
        //event 就是无参的
        public event Action BabyCryHandler;
        public void CryEvent()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "CryEvent");

            if (BabyCryHandler != null)
            {
                //BabyCryHandler();
                BabyCryHandler.Invoke();
            }
        }
    }
}
