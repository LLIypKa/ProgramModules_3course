using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2
{
    abstract class Observer
    {
        abstract public void Update();

        abstract public void OnInfo(Subject sender, string info);
    }
}
