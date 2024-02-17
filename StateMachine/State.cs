using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    abstract class State
    {
        public abstract string Handle();
    }
}
