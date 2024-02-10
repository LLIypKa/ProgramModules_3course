using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecoratorA: Decorator
    {
        private char _ch;

        public override string Operation()
        {
            return $"{_ch}{_comp.Operation()}{_ch}";
        }

        public ConcreteDecoratorA(Component cmp, char ch)
        {
            _ch = ch;
            _comp = cmp;
        }
    }
}
