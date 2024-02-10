using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_2
{
    class ConcreteTarget: Target
    {
        private int _a;
        private int _b;

        public override int GetA()
        {
            return _a;
        }

        public override int GetB()
        {
            return _b;
        }

        public override int Request()
        {
            return _a + _b;
        }

        public ConcreteTarget(int a, int b)
        {
            _a = a;
            _b = b;
        }
    }
}
