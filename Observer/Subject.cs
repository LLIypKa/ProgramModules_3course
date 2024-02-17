using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Subject
    {
        public delegate void NotifyEvenHandler();
        public event NotifyEvenHandler OnNotify;

        protected void Notify()
        {
            if (OnNotify != null) OnNotify();
        }
    }
}
