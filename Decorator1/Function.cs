using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator1
{
    abstract class Function
    {
        public abstract string GetName();

        public abstract int GetValue(int x);
    }
}
