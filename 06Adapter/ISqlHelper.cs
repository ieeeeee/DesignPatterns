using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Adapter
{
    public interface ISqlHelper
    {
        void Add();
        void Delete();
        void Update();
        void Search();

    }
}
