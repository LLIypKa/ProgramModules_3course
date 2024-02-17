using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    class ConcreteObserver: Observer
    {
        private string _log;
        private char _detachInfo;

        public override void OnInfo(Subject sender, string info)
        {
            _log += info;
            if (info.IndexOf(_detachInfo) + 1 == info.Length)
            {
                Dettach(sender);
            }
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public void Attach(Subject subj)
        {
            subj.Attach(this);
        }

        public void Dettach(Subject subj)
        {
            subj.Detach(this);
        }

        public string GetLog()
        {
            return _log;
        }

        public ConcreteObserver(char dI)
        {
            _detachInfo = dI;
            _log = string.Empty;
        }
    }
}
