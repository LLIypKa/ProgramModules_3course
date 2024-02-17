using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class Subject
    {
        public delegate void NotifyEvenHandler();
        public event NotifyEvenHandler OnNotify;

        internal List<Observer> observers = new List<Observer>();

        public void Attach(Observer observ)
        {
            observers.Add(observ);
        }

        public void Detach(Observer observ) 
        { 
            observers.Remove(observ);
        }

        

        protected void Notify()
        {
            if (OnNotify != null) OnNotify();
        }
    }
}
