using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Command
{
   public class ReadReceiver:BaseReceiver
    {
        public override void Execute(Document doc)
        {
            Console.WriteLine("{0} Read,{1}", this.GetType(), doc.Content);
        }
    }
}
