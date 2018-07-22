using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Mediator
{
   public  class SomebodyA
    {
        private string Name = null;
        public SomebodyA(string name)
        {
            this.Name = name;
        }
        public void SendMessage(string text,SomebodyB somebody)
        {
            Console.WriteLine("{0} Send: {1}", this.Name, text);
            somebody.ReceiveMessage(text);
        }

        public void ReceiveMessage(string text)
        {
            Console.WriteLine("{0} Receive: {1}", this.Name, text);
        }
    }

    public class SomebodyB
    {
        private string Name = null;
        public SomebodyB(string name)
        {
            this.Name = name;
        }
        public void SendMessage(string text, SomebodyA somebody)
        {
            Console.WriteLine("{0} Send: {1}", this.Name, text);
            somebody.ReceiveMessage(text);
        }

        public void ReceiveMessage(string text)
        {
            Console.WriteLine("{0} Receive: {1}", this.Name, text);
        }
    }
}
