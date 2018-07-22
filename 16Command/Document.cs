using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Command
{
    /// <summary>
    /// 文档
    /// </summary>
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }

        public void Read()
        {
            Console.WriteLine("{0} Read,{1}", this.GetType(), this.Content);
        }

        public void Write()
        {
            Console.WriteLine("{0} Write,{1}", this.GetType(), this.Content);
        }
    }
}
