using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Adapter
{
   public  class PhoneAdapter
    {

        private IPhone _IPhone;
        public PhoneAdapter(IPhone iPhone)
        {
            _IPhone = iPhone;
        }

        public void Call()
        {
            _IPhone.Call();
        }

        public void VideoChat()
        {
            Console.WriteLine("VideoChat");
        }
    }
}
