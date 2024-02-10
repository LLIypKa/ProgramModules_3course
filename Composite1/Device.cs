using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite1
{
    abstract class Device
    {
        public virtual void Add(Device d)
        {

        }

        public abstract string GetName();

        public abstract int GetTotalPrice();
    }
}
