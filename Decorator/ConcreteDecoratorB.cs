using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecoratorB: Decorator
    {
        public override string Operation()
        {
            return $"({_comp.Operation()})";    
        }

        public ConcreteDecoratorB(Component cmp)
        {
            _comp = cmp;
        }
    }
}
