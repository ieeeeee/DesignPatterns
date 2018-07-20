using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Adapter
{
    public class MyLuceneAdapter:MyLucene,ISqlHelper
    {
        public void Add()
        {
            base.Add();
        }

        public void Delete()
        {
            base.Delete();
        }

        public void Update()
        {
            Console.WriteLine("根本没有实现");
            //throw new NotImplementedException();

            base.Delete();
            base.Add();

        }

        public void Search()
        {
            base.Search();
        }
    }
}
