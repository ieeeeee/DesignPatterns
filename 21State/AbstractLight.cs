using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21State
{
    public abstract class AbstractLight
    {
        public LightState State
        {
            get;
            private set;
        }

        public AbstractLight(LightState state)
        {
            this.State = state;
        }
        public abstract void Change(Context context);
    }
}
