using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Adaptee
    {
        private int _a;
        private int _b;
        
        public int[] GetAll()
        {
            return new int[] { _a, _b };
        }

        public int SpecificRequest()
        {
            return _a * _b;
        }

        public Adaptee(int a, int b)
        {
            _a = a;
            _b = b;
        }
    }
}
