﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Stratege
{
    public class MutiplyStrategy:BaseStrategy
    {
        public override int Calculation()
        {
            return LeftInput * RightInput;
        }
    }
}
