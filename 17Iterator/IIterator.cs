using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Iterator
{
    public interface IIterator<T>
    {
        T Get();

        bool IsEnd();
    }
}
