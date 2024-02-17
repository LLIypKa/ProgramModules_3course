using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxi
{
    class Proxy: Subject
    {
        private bool _defferedMode;
        private bool _protectedMode;
        private RealSubject? _rsubj;

        public override string RequestA()
        {
            if(!_protectedMode && _rsubj != null)
            {
                return _rsubj.RequestA();
            }

            if (!_protectedMode && _rsubj == null)
                return "A(proxy)";

            if(_protectedMode && _rsubj == null)
                return "A(proxy)";

            return _rsubj.RequestA();
        }

        public override string RequestB()
        {
            if (!_protectedMode && _rsubj != null)
            {
                return _rsubj.RequestB();
            }

            if (!_protectedMode && _rsubj == null)
                return "B(proxy)";

            return "B(denied)";
        }

        public override string RequestC()
        {
            if (!_protectedMode && _rsubj != null)
            {
                return _rsubj.RequestC();
            }

            //if (!_protectedMode && _rsubj == null)
            //{
            //    _rsubj = new RealSubject();
            //    return _rsubj.RequestC();
            //}

            _rsubj = new RealSubject();
            return _rsubj.RequestC();
        }

        public override string RequestD()
        {
            if (!_protectedMode && _rsubj != null)
            {
                return _rsubj.RequestD();
            }

            if (!_protectedMode && _rsubj == null)
            {
                _rsubj = new RealSubject();
                return _rsubj.RequestD();
            }

            return "D(denied)";
        }

        public Proxy(bool dM, bool pM)
        {
            if (!dM)
            {
                _rsubj = new RealSubject();
            }
            else _rsubj = null;

            _defferedMode = dM;
            _protectedMode = pM;
        }
    }
}
