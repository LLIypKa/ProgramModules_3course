using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Abstraction
    {
        protected Implementor _imp;
        protected int _size;

        public virtual string Show()
        {
            return _imp.DrawLine(_size);
        }

        public virtual void SetSize(int n)
        {
            _size = n;
        }

        public Abstraction(Implementor imp, int size)
        {
            _imp = imp;
            _size = size;
        }
    }
}
