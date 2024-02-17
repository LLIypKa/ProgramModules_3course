using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteSubject: Subject
    {
        private char _state;

        public delegate void NotifyEvenHandler();
        public event NotifyEvenHandler OnNotify;

        public void SetState(char st)
        {
            if (_state != st)
            {
                _state = st;
                //Console.WriteLine("hihihaha");
                if (OnNotify != null) OnNotify.Invoke();
            }
        }

        public char GetState()
        {
            return _state;
        }

        protected void Notify()
        {
            if (OnNotify != null) OnNotify();
        }

        public ConcreteSubject() 
        {
            _state = ' ';
        }
    }
}
