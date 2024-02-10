using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Component
    {
        public virtual void AddComponent(Component otherComponent)
        {

        }

        abstract public string Operation();
    }
}
