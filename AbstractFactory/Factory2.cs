using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Factory2 : ControlFactory
    {
        //public string text { get { return text; } set { text = value; } }

        public override AbstractButton CreateButton(string text)
        {
            return new Button2(text);
        }

        public override AbstractLabel CreateLabel(string text)
        {
            return new Label2(text);
        }
    }
}
