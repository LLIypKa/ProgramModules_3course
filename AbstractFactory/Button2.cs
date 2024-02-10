using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Button2: AbstractButton
    {
        private string _text;

        public Button2(string text)
        {
            _text = "<";
            foreach (char s in text)
            {
                _text += Char.ToLower(s);
            }
            _text += ">";
            this.Text = _text;
        }

        public override string GetControl()
        {
            return _text;
        }
    }
}
