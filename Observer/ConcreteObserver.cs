using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserver: Observer1
    {
        private string? _log;
        private char? _detachInfo;
        private ConcreteSubject _subj = new ConcreteSubject();

        public void Attach()
        {
            _subj.OnNotify += Update;
        }

        public void Detach()
        {
            _subj.OnNotify -= Update;
        }

        public string GetLog()
        {
            return _log;
        }

        public override void Update()
        {
            _log += _subj.GetState();
            if (_detachInfo == _subj.GetState()) Detach();
        }

        public ConcreteObserver(char? detachInfo, ConcreteSubject subj)
        {
            _log = string.Empty;
            _detachInfo = detachInfo;
            this._subj = subj;
        }
    }
}
