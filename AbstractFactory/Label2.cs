using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Label2: AbstractLabel
    {
        private string _text;

        public Label2(string text)
        {
            _text = "\u0022";
            foreach (char s in text)
            {
                _text += Char.ToLower(s);
            }
            _text += "\"";
            this.Text = _text;
        }

        public override string GetControl()
        {
            return _text;
        }
    }
}
