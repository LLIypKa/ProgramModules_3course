using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_2
{
    abstract class Target
    {
        abstract public int GetA();

        abstract public int GetB();

        abstract public int Request();
    }
}
