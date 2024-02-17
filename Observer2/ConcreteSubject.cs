using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class ConcreteSubject: Subject
    {
        public delegate void NotifyEvenHandler();
        public event NotifyEvenHandler OnNotify;
        private string _state;

        public void SetState(string st)
        {
            if(st!=_state)
            {
                _state = st;
                if (OnNotify != null) OnNotify.Invoke();
            }
        }

        protected void Notify()
        {
            if (OnNotify != null) OnNotify();
        }

        public ConcreteSubject()
        {
            _state = string.Empty;
        }
    }
}
