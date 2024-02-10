using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RefinedAbstraction: Abstraction
    {
        private string _text;

        public override string Show()
        {
            if (1 + _text.Length > _size)
            {
                return _imp.DrawLine(1) + _imp.DrawText(_text.Substring(0, _size - 1));
            }

            return _imp.DrawLine(1) + _imp.DrawText(_text) + _imp.DrawLine(_size - 1 - _text.Length);
        }

        public override void SetSize(int n)
        {
            _size = n;
        }

        public RefinedAbstraction(Implementor imp, int size, string text): base(imp, size)
        { 
            _text = text;
        }
    }
}
