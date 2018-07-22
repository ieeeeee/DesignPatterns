using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Flyweight
{
    public abstract  class AbstractCharactor
    {
        public int Id { get; set; }
        public int Size { get; set; }

        public abstract string GetWord();
    }
}
