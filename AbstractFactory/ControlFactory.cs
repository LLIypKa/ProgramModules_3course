using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class ControlFactory
    { 
        abstract public AbstractButton CreateButton(string text);

        abstract public AbstractLabel CreateLabel(string text);
    }
}
