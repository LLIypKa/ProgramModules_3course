﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Implementor
    {
        public abstract string DrawLine(int size);

        public abstract string DrawText(string text);
    }
}
