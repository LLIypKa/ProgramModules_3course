using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator1
{
   class FX: Function
   {
        public override string GetName()
        {
            return "X";
        }

        public override int GetValue(int x)
        {
            return x;
        }
    }
}
