using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Mediator
{
    public class Student
    {
        public string Name = null;

        public Student(string name)
        {
            this.Name = name;
        }

        public void SendMessage(string text, ChatMediator mediator)//中介应该有个接口
        {
            Console.WriteLine("{0} Send: {1}", this.Name, text);
            mediator.SendMessage(this, text);
        }

        public void ReceiveMessage(string text)
        {
            Console.WriteLine("{0} Receive: {1}", this.Name, text);
        }
    }
}
