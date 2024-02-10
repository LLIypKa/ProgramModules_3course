using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Leaf: Component
    {
        private char _data;

        public override string Operation()
        {
            return $"{_data}()";
        }

        public Leaf(char character)
        {
            _data = character;
        }
    }
}
