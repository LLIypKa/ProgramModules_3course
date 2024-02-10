using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteComponent: Component
    {
        private string _text;

        public override string Operation()
        {
            return _text;
        }

        public ConcreteComponent(string text)
        {
            _text = text;
        }
    }
}
