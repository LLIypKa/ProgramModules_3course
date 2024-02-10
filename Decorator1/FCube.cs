using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator1
{
    class FCube: Function
    {
        private Function _f;
        public Function Function { get { return _f; } }

        public override string GetName()
        {
            return $"({_f.GetName()})^3";
        }

        public override int GetValue(int x)
        {
            return _f.GetValue(x) * _f.GetValue(x) * _f.GetValue(x);
        }

        public FCube(Function f)
        {
            _f = f;
        }
    }
}
