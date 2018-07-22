﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Observer
{
   public  class Neighboor
    {
        public void Awake()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "Awake");
        }
        public void Notify()
        {
            this.Awake();
        }
    }
}