﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator1
{
    class FTripple: Function
    {
        private Function _f;
        public Function Function { get { return _f; } }

        public override string GetName()
        {
            return $"3*({_f.GetName()})";
        }

        public override int GetValue(int x)
        {
            return _f.GetValue(x) * 3;
        }

        public FTripple(Function f)
        {
            _f = f;
        }
    }
}
